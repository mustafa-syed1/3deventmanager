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
using DevExpress.XtraEditors.Controls;
using System.Threading;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class Form_Main : Form
    {
        public _3Dproject project;
        public Wellcome wellcomeForm;
        public Form_Main(Wellcome wellcomeForm,bool isNew)
        {
            InitializeComponent();
            project = new _3Dproject();
            this.wellcomeForm = wellcomeForm;
            project = wellcomeForm.project;
            
            this.InitDockableForms();

            if (isNew)
            {
                project.projObjects = new selectedObjects();
            }
            else if (!isNew)
            {
                this.LoadObjectsFromUnity();
            }
        }
        public void LoadObjectsFromUnity()
        {
           
        }

        private void InitDockableForms()
        {
            Form_Renderer form_renderer;

            objApropForm objpropFrom = new objApropForm();
            objpropFrom.Show(dockPanel_main, DockState.DockRight);

            form_renderer = new Form_Renderer();
            form_renderer.Show(dockPanel_main, DockState.Document);

            ObjectsList form_Object = new ObjectsList();
            form_Object.Show(dockPanel_main,DockState.DockLeft);
            
            Form_Console form_console = new Form_Console();
            form_console.Show(dockPanel_main,DockState.DockBottom);

            formsComunication fc = new formsComunication(form_console,this, form_Object, form_renderer,objpropFrom);            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
                  DialogResult dialogResult = MessageBox.Show("Do You Want To Save Your Data", "Quit", MessageBoxButtons.YesNo);
                  if (dialogResult == DialogResult.Yes)
                  {
           //           MessageBox.Show((project.projObjects.return_objSelected()).Count.ToString());
                  }
                  this.wellcomeForm.Close();
           
        }
        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsComunication.formRenderer.sendObjects();
            Thread Showprogress = new Thread(new ThreadStart(showProgress));
            Showprogress.Start();
        }
        public void showProgress()
        {
            Thread.Sleep(1000);
            if (!(project.projLocation.Last() == '\\')) {project.projLocation = project.projLocation + "\\"; }
            project.save_project(project);
            MessageBox.Show("Project is saved sucessfully");
        }
    }
}