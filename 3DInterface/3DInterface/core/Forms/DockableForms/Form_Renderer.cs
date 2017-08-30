using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using WeifenLuo.WinFormsUI.Docking;

namespace _3DInterface.core.Forms.DockableForms
{
    [ComVisible(true)]
    [PermissionSet(SecurityAction.Demand, Name ="FullTrust")]
    public partial class Form_Renderer : DockContent
    {
        private string currentDirectory = string.Empty;
        string path_to_unityAssets = "/core/Unity/Renderer.html";
        public Form_Renderer()
        {
            InitializeComponent();
            this.currentDirectory = Directory.GetCurrentDirectory();
            webBrowser_Renderer.Url = new Uri(string.Format("{0}{1}",currentDirectory,path_to_unityAssets));
        }

        private void webBrowser_Renderer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_Renderer.ObjectForScripting = this;
        }
    }
}
