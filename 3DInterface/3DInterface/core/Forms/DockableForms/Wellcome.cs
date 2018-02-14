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
    public partial class Wellcome : Form
    {
        public _3Dproject project = null;
        public Wellcome()
        {
            InitializeComponent();
        }
        private void Wellcome_Load(object sender, EventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            newProjectForm projForm = new newProjectForm(this);
            projForm.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            string projName = "";
            string pathName = "";   
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                projName = ofd.SafeFileName;
                pathName = ofd.FileName;
            }
            this.project = new _3Dproject();
            project.projLocation = pathName;
            Form_Main main = new Form_Main(this,false);
            main.Show();
            this.Hide();            
        }
    }
}