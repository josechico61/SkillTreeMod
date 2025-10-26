using HarmonyLib;
using UnityEngine;

namespace SkillTreeMod
{
    // Example: runs once when the game loads the main menu
    [HarmonyPatch(typeof(uGUIWindowMainMenu), "OnOpen")]
    public static class SamplePatch
    {
        static void Postfix()
        {
            Debug.Log("[SkillTreeMod] Loaded! (SamplePatch ran)");
            // Later: initialize our skill tree data here
        }
    }
}
