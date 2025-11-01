using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// Attach this to the *button* that has on_press="true"
public class XUiC_SkillTreeCloseButton : XUiController
{
    public override void Init()
    {
        base.Init();
    }

    // This is what the framework calls when the button is pressed
    public override void OnPressed(int _mouseButton)
    {
        base.OnPressed(_mouseButton);

        // Convention in 7DTD: -1 = left, -2 = right
        if (_mouseButton == -1) // left click
        {
            // Close the whole group; this will trigger the group's OnClose()
            xui.playerUI.windowManager.CloseIfOpen("SkillTreeMenu");
        }
    }

    // (Optional) If you prefer the event style, you can also subscribe in Init():
    // this.OnPress += (sender, mb) => { if (mb == -1) xui.playerUI.windowManager.CloseIfOpen("skilltree"); };
    // But don't do both, or you'll handle it twice.
}