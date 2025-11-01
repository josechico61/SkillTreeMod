using System.Reflection;
using HarmonyLib;
using UnityEngine;

public class SkillTreeModEntry : IModApi
{
    public void InitMod(Mod _modInstance)
    {
        var harmony = new Harmony("po.skilltreemod");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
        Debug.Log("[SkillTreeMod] Harmony patched");
    }
}
