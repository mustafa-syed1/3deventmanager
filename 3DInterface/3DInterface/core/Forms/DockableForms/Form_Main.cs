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
        public currentSelectedObject currentSelectedObj;
        public Wellcome wellcomeForm;
        public bool isNew;
        public int nPeople = 0;
        public Form_Main(Wellcome wellcomeForm,bool isNew)
        {
            InitializeComponent();

            this.isNew = isNew;
            project = new _3Dproject();
            this.wellcomeForm = wellcomeForm;
            project = wellcomeForm.project;
            this.InitDockableForms();
  
        }

        public void check_isNew()
        {
            if (isNew)
            {
                project.projObjects = new selectedObjects();
            }
            else if (!isNew)
            {
                this.LoadObjects();
            }
        }
        public void LoadObjects()
        {
            UIController FormComunication = new UIController();
            FormComunication.loadProject(project.projLocation);
        }
        private void InitDockableForms()
        {
            MainController form_renderer;
            Form_manageTransforms TransformForm = new Form_manageTransforms();
            TransformForm.Show(dockPanel_main, DockState.DockTop);
            objApropForm objpropFrom = new objApropForm();
            objpropFrom.Show(dockPanel_main, DockState.DockRight);
            
            ObjectsList form_Object = new ObjectsList();
            form_Object.Show(dockPanel_main,DockState.DockLeft);
            Form_Console form_console = new Form_Console();
            form_console.Show(dockPanel_main,DockState.DockBottom);

            form_renderer = new MainController();
            form_renderer.Show(dockPanel_main, DockState.Document);
            UIController fc = new UIController(form_console,this, form_Object, form_renderer,objpropFrom,this.wellcomeForm);

            this.currentSelectedObj = new currentSelectedObject();

            Thread checkISnewProject = new Thread(new ThreadStart(check_isNew));
            checkISnewProject.Start();

        }
        private void Form_Main_Load(object sender, EventArgs e)
        {}
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
                  DialogResult dialogResult = MessageBox.Show("Do You Want To Save Your Data", "Quit", MessageBoxButtons.YesNo);
                  if (dialogResult == DialogResult.Yes)
                  {
                        if (!(project.projLocation.Last() == '\\')) { project.projLocation = project.projLocation + "\\"; }
                        project.save_project(project);
                        MessageBox.Show("Project is saved sucessfully");
                  }
                  this.wellcomeForm.Close();           
        }
        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(project.projLocation.Last() == '\\')) { project.projLocation = project.projLocation + "\\"; }
            project.save_project(project);
            MessageBox.Show("Project is saved sucessfully");
        }
    }
}