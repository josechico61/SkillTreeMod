using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class ConsoleCmd_Reflect : ConsoleCmdAbstract
{
    public override string[] getCommands() => new[] { "stm.reflect", "stm.scan" };
    public override string getDescription() =>
        "stm.reflect <TypeNameFragment> — lists matching types, properties, and methods";

    public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
    {
        if (_params.Count == 0) { SdtdConsole.Instance.Output("Usage: stm.reflect <nameFragment>"); return; }
        var needle = _params[0].ToLowerInvariant();

        // Search all loaded assemblies the game/mods use
        var asms = AppDomain.CurrentDomain.GetAssemblies();
        var allTypes = asms.SelectMany(a => {
            try { return a.GetTypes(); } catch { return Type.EmptyTypes; }
        });

        var matches = allTypes.Where(t => t.FullName != null && t.FullName.ToLowerInvariant().Contains(needle))
                              .OrderBy(t => t.FullName).Take(20).ToList();

        if (matches.Count == 0) { SdtdConsole.Instance.Output($"No types matching '{needle}'"); return; }

        foreach (var t in matches)
        {
            SdtdConsole.Instance.Output($"-- {t.FullName}");
            // properties
            foreach (var p in t.GetProperties(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static))
                SdtdConsole.Instance.Output($"   prop {p.PropertyType.Name} {p.Name} (get:{p.CanRead} set:{p.CanWrite})");

            // methods (names only to keep it readable)
            foreach (var m in t.GetMethods(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static|BindingFlags.DeclaredOnly))
                SdtdConsole.Instance.Output($"   meth {m.ReturnType.Name} {m.Name}({string.Join(", ", m.GetParameters().Select(x=>x.ParameterType.Name))})");
        }
    }
}
