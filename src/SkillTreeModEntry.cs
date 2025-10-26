using SkillTreeMod.Core;

public static class SkillTreeModEntry
{
    private static PlayerSkillState _state = new PlayerSkillState();
    private static bool _seeded;

    public static void InitIfNeeded()
    {
        if (_seeded) return;
        SkillRegistry.SeedDefaults();
        _seeded = true;
    }

    public static int CurrentUnspentPoints() { InitIfNeeded(); return _state.UnspentPoints; }
    public static void SafeAddPoints(int n) { InitIfNeeded(); _state.AddPoints(n); }
    public static void SafeReset() { InitIfNeeded(); _state.ResetAll(); }
}
