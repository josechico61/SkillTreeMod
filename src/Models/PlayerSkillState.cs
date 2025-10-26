using System.Collections.Generic;

namespace SkillTreeMod.Core
{
    public sealed class PlayerSkillState
    {
        public int UnspentPoints { get; private set; }
        public HashSet<string> Unlocked { get; private set; }

        public PlayerSkillState()
        {
            Unlocked = new HashSet<string>();
        }

        public void AddPoints(int n) { if (n > 0) UnspentPoints += n; }
        public bool SpendPoint(string key)
        {
            if (UnspentPoints <= 0) return false;
            var added = Unlocked.Add(key);
            if (added) UnspentPoints--;
            return added;
        }
        public void ResetAll() { Unlocked.Clear(); UnspentPoints = 0; }
    }
}
