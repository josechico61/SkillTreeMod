using HarmonyLib;
using UnityEngine;

namespace SkillTreeMod
{
    public class SkillTreeModApi : IModApi
    {
        public void InitMod(Mod modInstance)
        {
            Debug.Log("[SkillTreeMod] InitMod()");
            var harmony = new Harmony("com.josechico.SkillTreeMod");
            harmony.PatchAll();
        }
    }
}
