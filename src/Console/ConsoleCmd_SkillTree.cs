using System.Collections.Generic;

namespace SkillTreeMod.Console
{
    public class ConsoleCmd_SkillTree : ConsoleCmdAbstract
    {
        public override string[] getCommands() => new[] { "st", "skilltree" };
        public override string getDescription() => "SkillTreeMod admin/debug commands";

        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            if (_params.Count == 0) { Sd("usage: st givepoints <n> | st reset"); return; }
            var cmd = _params[0].ToLowerInvariant();
            if (cmd == "givepoints" && _params.Count >= 2 && int.TryParse(_params[1], out var n))
                SkillTreeModEntry.SafeAddPoints(n);
            else if (cmd == "reset")
                SkillTreeModEntry.SafeReset();
            else
                Sd("invalid command");
        }
        private void Sd(string s) => SingletonMonoBehaviour<SdtdConsole>.Instance?.Output(s);
    }
}
