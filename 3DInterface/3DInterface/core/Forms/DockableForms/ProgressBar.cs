using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label3.Text = "Processing..." + progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer1.Stop(); this.Close();
            }

            if (progressBar1.Value > 60)
            {
                label2.Text = "Finalaizing all the savings";
            }

            else if (progressBar1.Value > 40)
            {
                label2.Text = "all the transformations";
            }
            else if (progressBar1.Value > 20)
            {
                label2.Text = "all the textures";
            }
        }
    }
}
