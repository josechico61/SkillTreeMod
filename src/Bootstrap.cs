using HarmonyLib;
using System.Reflection;

namespace SkillTreeMod
{
    public static class Bootstrap
    {
        private static Harmony _harmony;

        public static void Init()
        {
            if (_harmony != null) return;
            _harmony = new Harmony("com.josechico.SkillTreeMod");
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
