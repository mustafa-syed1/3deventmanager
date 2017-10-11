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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            this.InitDockableForms();
        }

        private void InitDockableForms()
        {
            Form_Objects form_Object = new Form_Objects();
            form_Object.Show(dockPanel_main,DockState.DockLeft);

            Form_Renderer form_renderer = new Form_Renderer();
            form_renderer.Show(dockPanel_main,DockState.Document);

            Form_Console form_console = new Form_Console();
            form_console.Show(dockPanel_main,DockState.DockBottom);

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
