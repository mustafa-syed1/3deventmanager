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
    public partial class objApropForm : DockContent
    {
        public Properties prop;
        public Form_selectedObjects selectobjform;
        public objApropForm()
        {
            InitializeComponent();
            this.InitDockableForms();
        }
        private void InitDockableForms()
        {
            prop = new Properties();
            prop.Show(dockPanel_objAprop, DockState.Document);   
            selectobjform = new Form_selectedObjects();
            selectobjform.Show(dockPanel_objAprop, DockState.DockTop);
        }
    }
}