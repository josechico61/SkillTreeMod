using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;

namespace SkillTreeMod.HarmonyPatches
{
    public static class TraceInstaller
    {
        private static bool _installed;

        public static void Install(Harmony h)
        {
            if (_installed) return;

            // Candidate owner types (broad, but bounded)
            var ownerTypeNames = new[] { "Progression", "EntityPlayerLocal", "EntityPlayer" };

            // Candidate name fragments to catch leveling / xp
            var nameParts = new[] { "Level", "Lvl", "Exp", "XP", "Experience" };

            int patched = 0;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] types;
                try { types = asm.GetTypes(); } catch { continue; }
                foreach (var t in types)
                {
                    if (t.FullName == null) continue;
                    if (!ownerTypeNames.Any(n => t.FullName.EndsWith(n))) continue;

                    var methods = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
                                               BindingFlags.Instance | BindingFlags.DeclaredOnly);

                    foreach (var m in methods)
                    {
                        if (m.IsAbstract || m.IsGenericMethod) continue;
                        var n = m.Name;
                        if (!nameParts.Any(p => n.IndexOf(p, StringComparison.OrdinalIgnoreCase) >= 0))
                            continue;

                        // Avoid patching property getters that only read
                        if (n.StartsWith("get_", StringComparison.Ordinal)) continue;

                        try
                        {
                            var post = new HarmonyMethod(typeof(TracePostfix).GetMethod(nameof(TracePostfix.Postfix),
                                BindingFlags.Static | BindingFlags.Public));
                            h.Patch(m, postfix: post);
                            patched++;
                            if (patched >= 60) break; // safety cap
                        }
                        catch { /* ignore bad patch targets */ }
                    }
                    if (patched >= 60) break;
                }
                if (patched >= 60) break;
            }

            Log("trace installed on " + patched + " candidate methods (temporary)");
            _installed = true;
        }

        private static void Log(string s)
        {
            var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
            if (con != null) con.Output("[SkillTreeMod] " + s);
        }
    }

    public static class TracePostfix
    {
        public static void Postfix(MethodBase __originalMethod)
        {
            // This prints whenever one of the traced methods runs
            var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
            if (con != null && __originalMethod != null)
                con.Output("[SkillTreeMod][TRACE] " + __originalMethod.DeclaringType.FullName + "." + __originalMethod.Name + "()");
        }
    }
}
