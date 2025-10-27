using System;
using System.Collections.Generic;

public class ConsoleCmd_OpenSkillTree : ConsoleCmdAbstract
{
    public override string[] getCommands() => new[] { "skilltree.open" };
    public override string getDescription() => "Open the Skill Tree UI";

    public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
    {
        // Open via XUi console command from the *client* console context
        SdtdConsole.Instance.ExecuteSync("xui open skilltree", null);
    }
}
