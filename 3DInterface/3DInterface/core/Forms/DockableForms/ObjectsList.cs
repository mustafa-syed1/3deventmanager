using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WeifenLuo.WinFormsUI.Docking;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class ObjectsList : DockContent
    {
        delegate void DelegateAddImage(string imageFilename);
        private DelegateAddImage m_AddImageDelegate;
        public event ThumbnailImageEventHandler OnImageSizeChanged;
        private ThumbnailController m_Controller;
        private ImageDialog m_ImageDialog;
        private ImageViewer m_ActiveImageViewer;
        public ObjectsList()
        {
            m_ImageDialog = new ImageDialog();
            m_AddImageDelegate = new DelegateAddImage(this.AddImage);
            m_Controller = new ThumbnailController();
            m_Controller.OnStart += new ThumbnailControllerEventHandler(m_Controller_OnStart);
            m_Controller.OnAdd += new ThumbnailControllerEventHandler(m_Controller_OnAdd);
            m_Controller.OnEnd += new ThumbnailControllerEventHandler(m_Controller_OnEnd);
            InitializeComponent();
            AddButtons();
        }
        public void AddButtons()
        {
            //Searchbox properties
            Label imgLabel = new Label();
            imgLabel.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\icons\\search.png");
            imgLabel.AutoSize = false;
            imgLabel.Size = imgLabel.Image.Size;
            imgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            imgLabel.Text = "";
            imgLabel.BackColor = Color.Transparent;
            imgLabel.Parent = searchTxtBox;
            imgLabel.Location = new Point(searchTxtBox.ClientSize.Width - imgLabel.Image.Width, 1);
            m_Controller.AddFolder(System.IO.Directory.GetCurrentDirectory() + "//items//");
            DirectoryInfo dirs = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory() + "\\items");
            int top = 1;
            int btnId = 1;
            Panel objectPanel = new Panel();
            objectPanel.Width = 160;
            objectPanel.Height = 469;
            objectPanel.Location = new Point(5,38);
            objectPanel.BackColor = Color.FromArgb(41, 44, 51);
            objectPanel.AutoScroll = true;
            Controls.Add(objectPanel);
            foreach (DirectoryInfo dirInfo in dirs.GetDirectories())
            {
                Button dynamicButton = new Button();
                dynamicButton.Height = 40;
                dynamicButton.Width = 140;
                dynamicButton.Location = new Point(1, top);
                dynamicButton.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\icons\\" + dirInfo.Name.ToString() + "\\" + dirInfo.Name.ToString() + ".png");
                dynamicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                dynamicButton.Text = "         " + dirInfo.Name.ToString();
                dynamicButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                dynamicButton.Name = dirInfo.Name.ToString();
                dynamicButton.Font = new Font("Georgia", 11);
                dynamicButton.Click += new EventHandler(DynamicButton_Click);
                dynamicButton.BackColor = Color.Gray;
                dynamicButton.ForeColor = Color.White;             
                objectPanel.Controls.Add(dynamicButton);
                btnId++;
                top += 40;
            }
        }
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
            string ObjectName = btn.Name;
            this.flowLayoutPanel1.Controls.Clear();
            m_Controller.AddFolder(System.IO.Directory.GetCurrentDirectory() + "//items//" + ObjectName);
        }
        private void m_Controller_OnStart(object sender, ThumbnailControllerEventArgs e)
        {}
        private void m_Controller_OnAdd(object sender, ThumbnailControllerEventArgs e)
        {
            this.AddImage(e.ImageFilename);
            this.Invalidate();
        }
        private void m_Controller_OnEnd(object sender, ThumbnailControllerEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ThumbnailControllerEventHandler(m_Controller_OnEnd), sender, e);
            }
            else
            {}
        }
        private void addmain()
        {
            ImageList imagelist = new ImageList();
            System.Drawing.Image myImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\folder.png");
            imagelist.Images.Add(myImage);
            DirectoryInfo dirInfo = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory() + "\\items");
            if (dirInfo.Exists)
            {
                TreeNode mainNode = new TreeNode("items");
                mainNode.ImageIndex = 0;      
            }
        }
        private void AddImage(string imageFilename)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(m_AddImageDelegate, imageFilename);
            }
            else
            {
                int sizeLength = 100;
                int sizeWidht = 100;
                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 200, 200);
                imageViewer.Width = sizeLength;
                imageViewer.Height = sizeWidht;
                string[] name = imageFilename.Split(new char[] { '\\' });
                imageViewer.Name = name.Last();
                imageViewer.IsThumbnail = true;
                imageViewer.DoubleClick += new EventHandler(imag_double_click);
                this.OnImageSizeChanged += new ThumbnailImageEventHandler(imageViewer.ImageSizeChanged);
                this.flowLayoutPanel1.Controls.Add(imageViewer);
            }
        }
        public void imag_double_click(object sender, EventArgs e)
        {
            ImageViewer temp = (ImageViewer)sender;
            string s = temp.Name;

            string[] words1 = s.Split('.');
            string fnlimgName = "";
            bool is1st = true;
            foreach (string word in words1)
            {
                if (is1st)
                {
                    fnlimgName = word;
                    is1st = false;
                }
                is1st = false;
            }

            formsComunication.objprop.selectobjform.addChild(fnlimgName);
            formsComunication.formRenderer.sendMessage(s);
        }
        private void imageViewer_MouseClick(object sender, EventArgs e)
        {
            if (m_ActiveImageViewer != null)
            {
                m_ActiveImageViewer.IsActive = false;
            }
            m_ActiveImageViewer = (ImageViewer)sender;
            m_ActiveImageViewer.IsActive = true;
        }
        private void trackBarSize_Scroll(object sender, EventArgs e)
        {}
        private void button8_Click(object sender, EventArgs e)
        {
            String searchedString = searchTxtBox.Text.ToString();
            DirectoryInfo dirs = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory() + "\\items\\" + searchTxtBox.Text.ToString());
            if (dirs.Exists)
            {
                this.flowLayoutPanel1.Controls.Clear();
                m_Controller.AddFolder(System.IO.Directory.GetCurrentDirectory() + "//items//" + searchedString);
            }
            else
            {
                MessageBox.Show("Wrong Input, Enter correct name!");
            }
        }
    }
}
