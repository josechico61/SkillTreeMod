namespace SkillTreeMod.UI
{
    public class XUiC_SkillPointsBadge : XUiController
    {
        public override void Update(float _dt)
        {
            base.Update(_dt);

            var child = GetChildById("lblPoints");           // returns XUiController
            if (child != null)
            {
                var label = child.ViewComponent as XUiV_Label; // get the ViewComponent
                if (label != null)
                {
                    label.Text = "SP: " + SkillTreeModEntry.CurrentUnspentPoints();
                }
            }
        }
    }
}
