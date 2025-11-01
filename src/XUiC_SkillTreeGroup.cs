public class XUiC_SkillTreeGroup : XUiController
{
    private bool keepHudHidden;

    public override void OnOpen()
    {
        base.OnOpen();

        // tell UI a blocking menu is open (helps some builds)
        XUi.InGameMenuOpen = true;

        // force-hide belt view right now
        ForceHideView("toolbelt", true);

        keepHudHidden = true; // watchdog while we're open
    }

    public override void Update(float _dt)
    {
        base.Update(_dt);
        if (!keepHudHidden) return;

        // if anything tries to reopen it, shut it again
        xui.playerUI.windowManager.Close("toolbelt");

        // keep its view forced hidden
        ForceHideView("toolbelt", true);
    }

    public override void OnClose()
    {
        base.OnClose();

        keepHudHidden = false;

        // allow it to show again and ensure it’s back
        ForceHideView("toolbelt", false);
        xui.playerUI.windowManager.OpenIfNotOpen("toolbelt", false, false, true);

        XUi.InGameMenuOpen = false;
    }

    private void ForceHideView(string groupId, bool hide)
    {
        var ctrl = xui.FindWindowGroupByName(groupId);   // returns the group's controller
        var view = ctrl?.ViewComponent;
        if (view == null) return;

        view.ForceHide = hide;
        if (hide) view.IsVisible = false;   // collapse it immediately
    }
}
