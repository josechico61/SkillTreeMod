using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text;

public class ConsoleCmd_Dump : ConsoleCmdAbstract
{
    public override string[] getCommands() { return new[] { "stm.dump", "stm.type" }; }
    public override string getDescription()
    {
        return "stm.dump <TypeNameFragment> [optional: fullPath.txt] — dumps matching types/members to a text file";
    }

    public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
    {
        if (_params.Count == 0)
        {
            Out("usage: stm.dump <TypeNameFragment> [optional: fullPath.txt]");
            return;
        }

        string needle = _params[0].ToLowerInvariant();

        // Output file
        string path;
        if (_params.Count >= 2) path = _params[1];
        else
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var stamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            path = Path.Combine(desktop, "stm_dump_" + needle + "_" + stamp + ".txt");
        }

        // Find up to 100 matching types across loaded assemblies
        var asms = AppDomain.CurrentDomain.GetAssemblies();
        var allTypes = asms.SelectMany(a => { try { return a.GetTypes(); } catch { return Type.EmptyTypes; } });
        var matches = allTypes
            .Where(t => t.FullName != null && t.FullName.ToLowerInvariant().Contains(needle))
            .OrderBy(t => t.FullName)
            .Take(200)
            .ToList();

        if (matches.Count == 0) { Out("no types matching '" + needle + "'"); return; }

        var sb = new StringBuilder(2048);
        foreach (var t in matches)
        {
            sb.AppendLine("=== " + t.FullName + " ===");

            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;

            foreach (var f in t.GetFields(flags))
                sb.AppendLine("field " + (f.IsStatic ? "static " : "") + f.FieldType.Name + " " + f.Name);

            foreach (var p in t.GetProperties(flags))
            {
                bool isStatic = (p.GetGetMethod(true) != null && p.GetGetMethod(true).IsStatic)
                                || (p.GetSetMethod(true) != null && p.GetSetMethod(true).IsStatic);
                sb.AppendLine("prop  " + (isStatic ? "static " : "") + p.PropertyType.Name + " " + p.Name
                              + " (get:" + (p.CanRead ? "y" : "n") + " set:" + (p.CanWrite ? "y" : "n") + ")");
            }

            foreach (var m in t.GetMethods(flags))
            {
                var pars = string.Join(", ", m.GetParameters().Select(x => x.ParameterType.Name));
                sb.AppendLine("meth  " + (m.IsStatic ? "static " : "") + m.ReturnType.Name + " " + m.Name + "(" + pars + ")");
            }
            sb.AppendLine();
        }

        try
        {
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
            Out("dump wrote " + matches.Count + " type(s) to: " + path);
        }
        catch (Exception ex)
        {
            Out("dump failed: " + ex.GetType().Name + " - " + ex.Message);
        }
    }

    private void Out(string s)
    {
        var con = SingletonMonoBehaviour<SdtdConsole>.Instance;
        if (con != null) con.Output("[SkillTreeMod] " + s);
    }
}
