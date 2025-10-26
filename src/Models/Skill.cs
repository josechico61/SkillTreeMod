namespace SkillTreeMod.Core
{
    public sealed class Skill
    {
        public string Id { get; }
        public string DisplayName { get; }
        public string Description { get; }
        public int MaxLevel { get; }

        public Skill(string id, string displayName, string description, int maxLevel = 5)
        {
            Id = id; DisplayName = displayName; Description = description; MaxLevel = maxLevel;
        }
    }
}
