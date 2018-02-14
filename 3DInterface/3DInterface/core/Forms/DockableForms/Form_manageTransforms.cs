using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class Form_manageTransforms : DockContent
    {
        public Form_manageTransforms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UIController controller = new UIController();
            controller.flipLeft();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UIController controller = new UIController();
            controller.flipRight();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hallDesignInformation_Form info = new hallDesignInformation_Form();
            info.Show();
        }
    }
}
