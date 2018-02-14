using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class Properties : DockContent
    {
        public Properties()
        {
            InitializeComponent();       
        }
        public void setProperties(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ, bool istrigger)
        {
            this.textBox1.Text = objName;
            this.numericUpDown1.Text = positionX.ToString();
            this.numericUpDown2.Text = positionY.ToString();
            this.numericUpDown3.Text = positionZ.ToString();
            this.numericUpDown4.Text = rotationX.ToString();
            this.numericUpDown5.Text = rotationY.ToString();
            this.numericUpDown6.Text = rotationZ.ToString();
            this.numericUpDown7.Text = scaleX.ToString();
            this.numericUpDown8.Text = scaleY.ToString();
            this.numericUpDown9.Text = scaleZ.ToString();

            if(istrigger)
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox1.Checked = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            UIController controller = new UIController();
            controller.removeObjNode(textBox1.Text.ToString());
        }
        private void Properties_Load(object sender, EventArgs e)
        {}
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UIController controller = new UIController();
            controller.setProperties(this.textBox1.Text.ToString(), float.Parse(this.numericUpDown1.Text.ToString()), float.Parse(this.numericUpDown2.Text.ToString()), float.Parse(this.numericUpDown3.Text.ToString()), float.Parse(this.numericUpDown4.Text.ToString()), float.Parse(this.numericUpDown5.Text.ToString()), float.Parse(this.numericUpDown6.Text.ToString()), float.Parse(this.numericUpDown7.Text.ToString()), float.Parse(this.numericUpDown8.Text.ToString()), float.Parse(this.numericUpDown9.Text.ToString()));
        }

        public void flipObjectLeft()
        {
            numericUpDown5.Value = numericUpDown5.Value - 90;
        }

        public void flipObjectRight()
        {
            numericUpDown5.Value = numericUpDown5.Value + 90;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UIController controller = new UIController();
            if (textBox1.Text.ToString().Equals(""))
            {
                MessageBox.Show("The object name cannot be null, please enter valid name");
                return; 
            }
            else if(controller.isNotValidName(textBox1.Text.ToString()))
            {
                MessageBox.Show("An object with the similar name already exists!, please enter any other name");
                return;
            }
            else
            {
                controller.changeObjName(textBox1.Text.ToString());
            }
            
        }
    }
}