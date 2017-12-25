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
using WeifenLuo.WinFormsUI.Docking;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class Form_Object : DockContent
    {
        public event ThumbnailImageEventHandler OnImageSizeChanged;
   //     Form_Renderer fr;
        private ThumbnailController m_Controller;

        private ImageDialog m_ImageDialog;

        private ImageViewer m_ActiveImageViewer;
        

        private int ImageSize
        {
            get
            {
                return (64 * (this.trackBarSize.Value + 1));
            }
        }

        public Form_Object()
        {
            InitializeComponent();

            this.buttonCancel.Enabled = false;

            m_ImageDialog = new ImageDialog();

            m_AddImageDelegate = new DelegateAddImage(this.AddImage);

            m_Controller = new ThumbnailController();
            m_Controller.OnStart += new ThumbnailControllerEventHandler(m_Controller_OnStart);
            m_Controller.OnAdd += new ThumbnailControllerEventHandler(m_Controller_OnAdd);
            m_Controller.OnEnd += new ThumbnailControllerEventHandler(m_Controller_OnEnd);
            addmain();
            this.AddFolder();
            

        }

        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            this.AddFolder();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.m_Controller.CancelScanning = true;
        }

        private void AddFolder()
        {
           // FolderBrowserDialog dlg = new FolderBrowserDialog();
           // dlg.Description = @"Choose folder path";
           // if (dlg.ShowDialog() == DialogResult.OK)
            //{
                this.flowLayoutPanelMain.Controls.Clear();
                m_Controller.AddFolder(System.IO.Directory.GetCurrentDirectory()+"\\items");
                this.buttonCancel.Enabled = true;
                this.buttonBrowseFolder.Enabled = false;
           // }
        }

        private void m_Controller_OnStart(object sender, ThumbnailControllerEventArgs e)
        {

        }

        private void m_Controller_OnAdd(object sender, ThumbnailControllerEventArgs e)
        {
            this.AddImage(e.ImageFilename);
            this.Invalidate();
        }

        private void m_Controller_OnEnd(object sender, ThumbnailControllerEventArgs e)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(new ThumbnailControllerEventHandler(m_Controller_OnEnd), sender, e);
            }
            else
            {
                this.buttonCancel.Enabled = false;
                this.buttonBrowseFolder.Enabled = true;
            }
        }

        delegate void DelegateAddImage(string imageFilename);
        private DelegateAddImage m_AddImageDelegate;

        private void AddImage(string imageFilename)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(m_AddImageDelegate, imageFilename);
            }
            else
            {
                int size = ImageSize;

                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 256, 256);
                imageViewer.Width = size;
                imageViewer.Height = size;
                string[] name = imageFilename.Split(new char[] { '\\'});
                
                imageViewer.Name = name.Last();
                
                
                imageViewer.IsThumbnail = true;
                imageViewer.GotFocus += new EventHandler(imageViewer_MouseClick);
                imageViewer.DoubleClick += new EventHandler(imag_double_click);
                this.OnImageSizeChanged += new ThumbnailImageEventHandler(imageViewer.ImageSizeChanged);

                this.flowLayoutPanelMain.Controls.Add(imageViewer);
            }
        }

       public void  imag_double_click(object sender,EventArgs e)
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
    /*        
            if (m_ActiveImageViewer != null)
            {
                m_ActiveImageViewer.IsActive = false;
            }

            m_ActiveImageViewer = (ImageViewer)sender;
            m_ActiveImageViewer.IsActive = true;

            if (m_ImageDialog.IsDisposed) m_ImageDialog = new ImageDialog();
            if (!m_ImageDialog.Visible) m_ImageDialog.Show();

            m_ImageDialog.SetImage(m_ActiveImageViewer.ImageLocation);
   */     }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            this.OnImageSizeChanged(this, new ThumbnailImageEventArgs(ImageSize));
        }

       

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addmain()
        {
            ImageList imagelist = new ImageList();
           System.Drawing.Image myImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory()+ "\\folder.png");
            imagelist.Images.Add(myImage);
            DirectoryInfo dirInfo = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory() + "\\items");
            if (dirInfo.Exists)
            {
                
                TreeNode mainNode = new TreeNode("items");
                mainNode.ImageIndex = 0;
                treeView1.Nodes.Add(mainNode);
                treeView1.ImageList = imagelist;
                AddChildNodes(mainNode, System.IO.Directory.GetCurrentDirectory() + "\\items");
                foreach (TreeNode node in treeView1.Nodes)
                {
                   
                }
            }
        }
        private void AddChildNodes(TreeNode rootNode, string rootFoder)
        {
            try
            {
                DirectoryInfo dirs = new DirectoryInfo(rootFoder);
                foreach (DirectoryInfo dirInfo in dirs.GetDirectories())
                {
                    TreeNode newnode = new TreeNode(dirInfo.Name);
                    rootNode.Nodes.Add(newnode);
                  //  FileInfo[] nestedFiles = null;
                 //   nestedFiles = dirInfo.GetFiles().ToArray();
                   // if (nestedFiles != null && nestedFiles.Length > 0)
                   // {
                       // foreach (FileInfo nestedFile in nestedFiles)
                       // {
                           // newnode.Nodes.Add(nestedFile.Name.ToString());
                       // }
                    //}
                    if (dirInfo.GetDirectories().Length > 0)
                    {
                        AddChildNodes(newnode, dirInfo.FullName);
                    }
                }
              //  FileInfo[] files = dirs.GetFiles();
              //  foreach (FileInfo file in files)
              //  {
                 //   rootNode.Nodes.Add(file.Name.ToString());
               // }
               // treeView1.ExpandAll();
               // treeView1.CheckBoxes = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
       

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeView t = (TreeView)sender;
            TreeNode n = t.SelectedNode;
            string s = n.Text;

            while (n.Parent != null)
            {
                
                n = n.Parent;
                string temp = n.Text;
                temp += "\\";
                temp += s;
                s = temp;

            }

           this.flowLayoutPanelMain.Controls.Clear();
           m_Controller.AddFolder(System.IO.Directory.GetCurrentDirectory() +"\\"+ s  );
            Console.WriteLine(s);
        }

       
    }

    public class ThumbnailImageEventArgs : EventArgs
    {
        public ThumbnailImageEventArgs(int size)
        {
            this.Size = size;
        }

        public int Size;
    }

    public delegate void ThumbnailImageEventHandler(object sender, ThumbnailImageEventArgs e);

}
