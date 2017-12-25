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
    public partial class Properties : DockContent
    {
        
        public Properties()
        {
            InitializeComponent();
            
        }

        public void setProperties(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ, bool istrigger)
        {
            // MessageBox.Show("Recieved : "+ objName + " " + positionX + " " + positionY + " " + positionZ + " " + rotationX + " " + rotationY + " " + rotationZ + " " + scaleX + " " + scaleY + " " + scaleZ + " " + istrigger);
            this.textBox1.Text = objName;
            this.textBox2.Text = positionX.ToString();
            this.textBox3.Text = positionY.ToString();
            this.textBox4.Text = positionZ.ToString();
            this.textBox5.Text = rotationX.ToString();
            this.textBox6.Text = rotationY.ToString();
            this.textBox7.Text = rotationZ.ToString();
            this.textBox8.Text = scaleX.ToString();
            this.textBox9.Text = scaleY.ToString();
            this.textBox10.Text = scaleZ.ToString();

            if(istrigger)
            {
                this.checkBox1.Checked = true;
            }
            else
            {
                this.checkBox1.Checked = false;
            }
        }

        private void transformChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formsComunication.formRenderer.delete();
        }

        private void Properties_Load(object sender, EventArgs e)
        {

        }
    }
}
