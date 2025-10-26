using System.Collections.Generic;

namespace SkillTreeMod.Core
{
    public sealed class SkillNode
    {
        public Skill Skill { get; }
        public int Level { get; }
        public List<string> Requires { get; private set; }

        public SkillNode(Skill skill, int level)
        {
            Skill = skill;
            Level = level;
            Requires = new List<string>();
        }
    }
}
