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
    public partial class Form_selectedObjects : DockContent
    {
        TreeNode mainNode;
        public Form_selectedObjects()
        {
            InitializeComponent();
            addmain();
        }
        private void addmain()
        {
            ImageList imagelist = new ImageList();
            System.Drawing.Image myImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\cube.png");
            imagelist.Images.Add(myImage);
            mainNode = new TreeNode("3D Objects");
            mainNode.ImageIndex = 0;
            treeView1.Nodes.Add(mainNode);
            treeView1.ImageList = imagelist;
            treeView1.ExpandAll();
        }
        public void addChild(string obj)
        {
            TreeNode newnode = new TreeNode(obj);
            mainNode.Nodes.Add(newnode);
            treeView1.ExpandAll();
        }
    }
}
