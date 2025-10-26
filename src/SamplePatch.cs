using HarmonyLib;
using UnityEngine;

namespace SkillTreeMod
{
    // Runs when the game manager wakes up (very early in startup)
    [HarmonyPatch(typeof(GameManager), "Awake")]
    public static class SamplePatch
    {
        static void Postfix()
        {
            Debug.Log("[SkillTreeMod] Loaded! (GameManager.Awake patched)");
        }
    }
}
