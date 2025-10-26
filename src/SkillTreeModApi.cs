using HarmonyLib;

namespace SkillTreeMod
{
    public class SkillTreeModApi : IModApi
    {
        public void InitMod(Mod modInstance)
        {
            Log("[SkillTreeMod] InitMod()");
            var h = new Harmony("com.josechico.SkillTreeMod");
            // DO NOT use PatchAll() – we install only if we find a target.
            SkillTreeMod.HarmonyPatches.PatchInstaller.Install(h);
        }

        private void Log(string s)
        {
            var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
            if (con != null) con.Output(s);
        }
    }
}
