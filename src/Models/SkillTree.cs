using System.Collections.Generic;

namespace SkillTreeMod.Core
{
    public sealed class SkillTree
    {
        public string Id { get; }
        public Dictionary<string, List<SkillNode>> Nodes { get; private set; }

        public SkillTree(string id)
        {
            Id = id;
            Nodes = new Dictionary<string, List<SkillNode>>();
        }

        public void AddNode(SkillNode node)
        {
            var key = node.Skill.Id;
            if (!Nodes.ContainsKey(key)) Nodes[key] = new List<SkillNode>();
            Nodes[key].Add(node);
        }
    }
}
