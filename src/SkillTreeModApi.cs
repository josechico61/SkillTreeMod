using HarmonyLib;

namespace SkillTreeMod
{
    public class SkillTreeModApi : IModApi
    {
        public void InitMod(Mod modInstance)
        {
            var h = new Harmony("com.josechico.SkillTreeMod");
            SkillTreeMod.HarmonyPatches.PatchInstaller.Install(h);   // our real (safe) patch
            SkillTreeMod.HarmonyPatches.TraceInstaller.Install(h);   // TEMP: tracer to discover hooks
        }
    }
}
