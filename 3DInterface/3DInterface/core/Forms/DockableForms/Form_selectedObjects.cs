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
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!e.Node.Text.Equals("3D Objects"))
            {
                UIController controller = new UIController();
                controller.FocusOnobj(e.Node.Text);
            }       
        }
        public void removeObjNode(string objName)
        {
            if(!objName.Equals("3D Objects"))
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    foreach (TreeNode inner_node in node.Nodes)
                    {
                        if (inner_node.Text.ToString().Equals(objName))
                        {
                            treeView1.Nodes.Remove(inner_node);
                            treeView1.Refresh();
                            UIController controller = new UIController();
                            controller.setUIProperties("", 0.00f, 0.00f, 0.00f, 0.00f, 0.00f, 0.00f, 0.00f, 0.00f, 0.00f, true);
                            return;
                        }
                    }
                }
            }
        }

        public void UpdateObjName(string newObjName, string preObjName)
        {
            if (!preObjName.Equals("3D Objects"))
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        if (node.Nodes[i].Text.ToString().Equals(preObjName))
                        {
                            node.Nodes[i].Text = newObjName;
                            return;
                        }
                    }
                }
            }
        }
        public void getSelected(string selectedObjName)
        {
            if (!selectedObjName.Equals("3D Objects"))
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    for (int i = 0; i < node.Nodes.Count; i++)
                    {
                        if (node.Nodes[i].Text.ToString().Equals(selectedObjName))
                        {
                            treeView1.SelectedNode = node.Nodes[i];
                            treeView1.Focus();
                            return;
                        }
                    }
                }
            }
        }
    }
}
/* 
*/
