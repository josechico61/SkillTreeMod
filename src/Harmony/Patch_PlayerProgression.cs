using System.Reflection;
using HarmonyLib;

namespace SkillTreeMod.HarmonyPatches
{
    // This patch resolves the progression type/method by name at runtime so it compiles
    // even if your game version uses "Progression" instead of "PlayerProgression".
    [HarmonyPatch]
    public static class Patch_PlayerProgression_Generic
    {
        // Try a few common type names and method names across versions
        static MethodBase TargetMethod()
        {
            // Candidate type names across versions
            var t =
                AccessTools.TypeByName("PlayerProgression") ??
                AccessTools.TypeByName("Progression");

            if (t == null) return null;

            // Candidate level-up methods across versions
            return
                AccessTools.Method(t, "OnLevelUp") ??
                AccessTools.Method(t, "LevelUp") ??
                AccessTools.Method(t, "OnLevelChanged") ??
                AccessTools.Method(t, "SetLevel"); // last resort
        }

        // Postfix runs after a level-up is detected
        static void Postfix()
        {
            // Award points safely; the helper handles lazy init
            SkillTreeModEntry.SafeAddPoints(SkillTreeMod.Core.SkillTreeSettings.PointsPerLevel);
        }
    }
}
