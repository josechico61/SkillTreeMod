using System.Collections.Generic;

namespace SkillTreeMod.Console
{
    public class ConsoleCmd_SkillTree : ConsoleCmdAbstract
    {
        public override string[] getCommands() { return new[] { "stm", "skilltree" }; } // avoid 'st' conflict
        public override string getDescription() { return "SkillTreeMod admin/debug commands"; }

        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            if (_params.Count == 0)
            {
                Out("usage: stm givepoints <n> | stm reset | stm probe");
                return;
            }

            var cmd = _params[0].ToLowerInvariant();

            if (cmd == "givepoints" && _params.Count >= 2)
            {
                int n;
                if (int.TryParse(_params[1], out n))
                {
                    SkillTreeModEntry.SafeAddPoints(n);
                    Out("ok: added " + n + " SP");
                }
                else Out("invalid number");
                return;
            }

            if (cmd == "reset")
            {
                SkillTreeModEntry.SafeReset();
                Out("ok: reset SP");
                return;
            }

            if (cmd == "probe")
            {
                var installed = SkillTreeMod.HarmonyPatches.PatchInstaller.Installed;
                var t = SkillTreeMod.HarmonyPatches.PatchInstaller.HookTypeName ?? "(none)";
                var m = SkillTreeMod.HarmonyPatches.PatchInstaller.HookMethodName ?? "(none)";
                Out("probe: installed=" + (installed ? "yes" : "no")
                    + " type=" + t + " method=" + m);
                return;
            }

            Out("invalid command");
        }

        private void Out(string s)
        {
            var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
            if (con != null) con.Output(s);
        }
    }
}
