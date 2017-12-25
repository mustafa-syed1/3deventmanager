using System;
using System.Windows.Forms;
using System.Drawing;

namespace _3DInterface.core.Forms.DockableForms
{
    public class ThumbnailFlowLayoutPanel : FlowLayoutPanel
    {
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }
    }
}
