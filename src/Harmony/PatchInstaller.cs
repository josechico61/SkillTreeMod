using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;

namespace SkillTreeMod.HarmonyPatches
{
    public static class PatchInstaller
    {
        public static bool Installed { get; private set; }
        public static string HookTypeName { get; private set; }
        public static string HookMethodName { get; private set; }

        public static void Install(Harmony h)
        {
            try
            {
                string tName, mName; // use locals for out params
                var original = ResolveProgressionMethod(out tName, out mName);

                HookTypeName = tName;
                HookMethodName = mName;

                if (original == null)
                {
                    Log("no progression hook found; skipping patch (mod will still run)");
                    return;
                }

                var postfix = new HarmonyMethod(typeof(LevelUpPostfix).GetMethod(
                    "Postfix", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));

                h.Patch(original, postfix: postfix);
                Installed = true;
                Log("patched " + HookTypeName + "." + HookMethodName + " (postfix)");
            }
            catch (Exception ex)
            {
                Log("patch install error: " + ex.GetType().Name + " - " + ex.Message);
            }
        }

        private static MethodBase ResolveProgressionMethod(out string typeName, out string methodName)
        {
            typeName = null; methodName = null;

            Type t = AccessTools.TypeByName("Progression")
                     ?? AccessTools.TypeByName("PlayerProgression")
                     ?? AccessTools.AllTypes().FirstOrDefault(tt => tt.Name.EndsWith("Progression"));

            if (t == null) return null;
            typeName = t.FullName;

            MethodInfo m =
                AccessTools.Method(t, "OnLevelUp") ??
                AccessTools.Method(t, "LevelUp") ??
                AccessTools.Method(t, "OnLevelChanged") ??
                AccessTools.Method(t, "ChangeLevel") ??
                AccessTools.Method(t, "AddLevel") ??
                AccessTools.Method(t, "SetLevel");

            if (m == null)
                m = AccessTools.PropertySetter(t, "Level");

            if (m != null) methodName = m.Name;
            return m;
        }

        private static void Log(string s)
        {
            var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
            if (con != null) con.Output("[SkillTreeMod] " + s);
        }
    }

    public static class LevelUpPostfix
    {
        public static void Postfix()
        {
            SkillTreeModEntry.SafeAddPoints(SkillTreeMod.Core.SkillTreeSettings.PointsPerLevel);
        }
    }
}
