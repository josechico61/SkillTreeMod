using SkillTreeMod.UI;

public class XUiC_SkillPointsBadge : XUiController
{
    private XUiV_Label _lbl;
    private int _lastSp = -1;

    public override void Init()
    {
        base.Init();
        var child = GetChildById("lblSP");
        if (child != null) _lbl = child.ViewComponent as XUiV_Label;
        UpdateSpText(true);
    }

    public override void Update(float _dt)
    {
        base.Update(_dt);
        UpdateSpText(false);
    }

    private void UpdateSpText(bool force)
    {
        var sp = UIHelpers.GetSkillPointsSafe();
        if (!force && sp == _lastSp) return;
        _lastSp = sp;

        if (_lbl != null) _lbl.Text = "SP: " + sp;
    }
}
