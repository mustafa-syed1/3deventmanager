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
    public partial class Form_Renderer : DockContent
    {
        private string currentDirectory = string.Empty;
        string path_to_unityAssets = "/core/Unity/Renderer.html";
        public int a = 0;
    //    public Properties prop;  
        public Form_Renderer()
        {
            InitializeComponent();
      //      this.prop = prop;
            this.currentDirectory = Directory.GetCurrentDirectory();
            webBrowser_Renderer.ObjectForScripting = new Proxy();
            webBrowser_Renderer.Url = new Uri(string.Format("{0}{1}",currentDirectory,path_to_unityAssets));
        }
        public void sendMessage(string msg)
        {
            Object[] obj = new Object[] { msg };
            webBrowser_Renderer.Document.InvokeScript("SaySomethingToUnity", obj);
            
        }
        public void delete()
        {
            webBrowser_Renderer.Document.InvokeScript("delObj");
        }
        public void SendObjProperties(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ, bool istrigger)
        {
            //     MessageBox.Show(objName + " " + positionX + " " + positionY + " " + positionZ + " " + rotationX + " " + rotationY + " " + rotationZ + " " + scaleX + " " + scaleY + " " + scaleZ + " " + istrigger);
            formsComunication.objprop.prop.setProperties(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, istrigger);
        }
        public void sendObjects()
        {
            Object[] obj = new Object[] { "sendObjects" };
            webBrowser_Renderer.Document.InvokeScript("sendObjects", obj);
        }

        [ComVisible(true)]
        public class Proxy
        {
            public Proxy()
            {}
            public void recieveMessage(string msg)
            {
                MessageBox.Show("Yes! Recieved");
            }
            public void ObjProperties(string objName,float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ,bool istrigger)
            {
           //     MessageBox.Show(objName + " " + positionX + " " + positionY + " " + positionZ + " " + rotationX + " " + rotationY + " " + rotationZ + " " + scaleX + " " + scaleY + " " + scaleZ + " " + istrigger);
                formsComunication.objprop.prop.setProperties(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, istrigger);
            }
            
            public void store_Objects(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ)
            {
                _3DObject _object = new _3DObject(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ);
                formsComunication.formMain.project.projObjects.addObject(_object);
        //        MessageBox.Show(objName);
            }
        }


    }
}
