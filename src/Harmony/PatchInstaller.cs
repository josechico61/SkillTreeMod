using System;
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
                string tName, mName;
                var target = ResolveProgressionXpMethod(out tName, out mName);

                HookTypeName = tName;
                HookMethodName = mName;

                if (target == null)
                {
                    Log("no suitable Progression XP method found; patch skipped");
                    return;
                }

                var pre = new HarmonyMethod(typeof(LevelUpDetector).GetMethod(nameof(LevelUpDetector.Prefix),
                              BindingFlags.Static | BindingFlags.Public));
                var post = new HarmonyMethod(typeof(LevelUpDetector).GetMethod(nameof(LevelUpDetector.Postfix),
                              BindingFlags.Static | BindingFlags.Public));

                h.Patch(target, prefix: pre, postfix: post);
                Installed = true;
                Log("patched " + HookTypeName + "." + HookMethodName + " (prefix+postfix)");
            }
            catch (Exception ex)
            {
                Log("patch install error: " + ex.GetType().Name + " - " + ex.Message);
            }
        }

        // Prefer Progression.AddLevelExpRecursive(int,string,bool), fallback to AddLevelExp(int,string,XPTypes,bool,bool)
        private static MethodBase ResolveProgressionXpMethod(out string typeName, out string methodName)
        {
            typeName = null; methodName = null;

            var t = AccessTools.TypeByName("Progression");
            if (t == null) return null;
            typeName = t.FullName;

            // Try the exact signatures first
            var m = AccessTools.Method(t, "AddLevelExpRecursive", new Type[] { typeof(int), typeof(string), typeof(bool) });
            if (m == null)
                m = AccessTools.Method(t, "AddLevelExp", new Type[] { typeof(int), typeof(string), AccessTools.TypeByName("Progression+XPTypes"), typeof(bool), typeof(bool) });

            if (m != null) methodName = m.Name;
            return m;
        }

        private static void Log(string s)
        {
            var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
            if (con != null) con.Output("[SkillTreeMod] " + s);
        }
    }

    // Works on Progression instance: compare Level before/after the XP add
    public static class LevelUpDetector
    {
        public static void Prefix(object __instance, ref int __state)
        {
            __state = ReadLevel(__instance);
        }

        public static void Postfix(object __instance, int __state)
        {
            var after = ReadLevel(__instance);
            if (__state > 0 && after > __state)
            {
                SkillTreeModEntry.SafeAddPoints(SkillTreeMod.Core.SkillTreeSettings.PointsPerLevel);
                var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
                if (con != null) con.Output("[SkillTreeMod] Level up detected (" + __state + "→" + after + "), awarded SP");
            }
        }

        private static int ReadLevel(object progressionObj)
        {
            if (progressionObj == null) return -1;
            try
            {
                var t = progressionObj.GetType();
                // field Int32 Level (from your dump)
                var f = t.GetField("Level", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (f != null)
                {
                    var val = f.GetValue(progressionObj);
                    if (val is int i) return i;
                }
                // property Int32 GetLevel() also exists; try method if needed
                var m = t.GetMethod("GetLevel", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m != null)
                {
                    var val2 = m.Invoke(progressionObj, null);
                    if (val2 is int j) return j;
                }
            }
            catch { }
            return -1;
        }
    }
}
