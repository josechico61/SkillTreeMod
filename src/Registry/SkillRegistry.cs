using System.Collections.Generic;

namespace SkillTreeMod.Core
{
    public static class SkillRegistry
    {
        private static readonly Dictionary<string, Skill> _skills = new Dictionary<string, Skill>();
        private static readonly Dictionary<string, SkillTree> _trees = new Dictionary<string, SkillTree>();

        public static void Register(Skill s)
        {
            if (!_skills.ContainsKey(s.Id)) _skills[s.Id] = s;
        }

        public static void RegisterTree(SkillTree t)
        {
            if (!_trees.ContainsKey(t.Id)) _trees[t.Id] = t;
        }

        public static IReadOnlyDictionary<string, Skill> Skills { get { return _skills; } }
        public static IReadOnlyDictionary<string, SkillTree> Trees { get { return _trees; } }

        public static void SeedDefaults()
        {
            if (_skills.Count > 0) return;
            var mining = new Skill("mining", "Mining", "Improves resource yield.", 5);
            Register(mining);

            var t = new SkillTree("core");
            t.AddNode(new SkillNode(mining, 1));
            t.AddNode(new SkillNode(mining, 2));
            t.AddNode(new SkillNode(mining, 3));
            RegisterTree(t);
        }
    }
}
