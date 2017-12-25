using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.IO;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class newProjectForm : Form
    {
        public Wellcome wellcomeForm;
        public string currentDirectory = Directory.GetCurrentDirectory() + "\\Halls";
        public string[] images;
        public Image currentImage;
        public int counter = 0;
        public newProjectForm(Wellcome wellcomeForm)
        {
            
            this.wellcomeForm = wellcomeForm;
            InitializeComponent();
            images = Directory.GetFiles(currentDirectory, "*.jpg");
            setImage();
        }

        public void setImage()
        {
            currentImage = Image.FromFile(images[counter]);
            setHallName();
            pictureBox1.Width = 230;
            pictureBox1.Height = 130;
            pictureBox1.Image = currentImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void setHallName()
        {
            string[] words = this.images[counter].Split('\\');
            string imgName="";
            foreach (string word in words)
            {
                imgName = word;
            }

            string[] words1 = imgName.Split('.');
            string fnlimgName = "";
            bool is1st = true;
            foreach (string word in words1)
            {
                if(is1st)
                {
                    fnlimgName = word;
                    is1st = false;
                }
                is1st = false;
            }
            label4.Text = fnlimgName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.RootFolder = Environment.SpecialFolder.Desktop;
            fdb.Description = "+++Select Folder+++";
          //  fdb.ShowNewFolderButton = false;

            if(fdb.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdb.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            wellcomeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            wellcomeForm.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(counter+1 < this.images.Length)
            {
                ++this.counter;
                setImage();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(counter - 1 > -1)
            {
                --this.counter;
                setImage();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            wellcomeForm.project = new _3Dproject();
            wellcomeForm.project.hallName = this.label4.Text.ToString();
            wellcomeForm.project.projLocation = this.textBox1.Text.ToString();
            wellcomeForm.project.projName = this.textBox2.Text.ToString();
            wellcomeForm.project.projObjects = new selectedObjects();
            this.Close();
            Form_Main frmMain = new Form_Main(wellcomeForm,true);
            frmMain.Show();
        }
    }
}
