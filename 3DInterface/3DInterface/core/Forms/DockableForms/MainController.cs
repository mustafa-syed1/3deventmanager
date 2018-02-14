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
using System.Threading;

namespace _3DInterface.core.Forms.DockableForms
{
    public partial class MainController : DockContent
    {
        private string currentDirectory = string.Empty;
        string path_to_unityAssets = "/core/Unity/Renderer.html";
        public int a = 0;
        private delegate void InvokeDelegate();
        public MainController()
        {
            InitializeComponent();
            this.currentDirectory = Directory.GetCurrentDirectory();
            webBrowser_Renderer.ObjectForScripting = new Proxy();
            webBrowser_Renderer.Url = new Uri(string.Format("{0}{1}",currentDirectory,path_to_unityAssets));
        }

        public void check(string msg)
        {
            MessageBox.Show(msg);
        }
        public void sendMessage(string msg)
        {
            Object[] obj = new Object[] { msg };
            webBrowser_Renderer.Document.InvokeScript("SaySomethingToUnity", obj);   
        }
        public void selectObject(string objName)
        {
            Object[] ObjName = new Object[] { objName };
            webBrowser_Renderer.Document.InvokeScript("InitiateObject_InUnity", ObjName);
        }
        public void delete()
        {
            webBrowser_Renderer.Document.InvokeScript("delObj");
        }
        public void SendObjProperties(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ, bool istrigger)
        {
            UIController controller = new UIController();
            controller.setUIObjProperties(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, istrigger);
        }
        public void sendObjects()
        {
            Object[] obj = new Object[] { "sendObjects" };
            webBrowser_Renderer.Document.InvokeScript("sendObjects", obj);
        }
        public void FocusOnobj(string objName)
        {
            Object[] Obj_Name = new Object[] { objName };
            webBrowser_Renderer.Document.InvokeScript("FocusOn_obj", Obj_Name);
        }
        public void setProperties(string objName,float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ)
        {
            string transformationParameters = posX+"#"+posY+"#"+posZ + "#" + rotX + "#" + rotY + "#" + rotZ + "#" + scaleX + "#" + scaleY + "#" + scaleZ;
            Object[] ObjAttributes = new Object[] { transformationParameters };
            webBrowser_Renderer.Document.InvokeScript("setObjProperties", ObjAttributes);
        }

        public void UpdateObjName(string newObjName,string preObjName)
        {
            Object[] Obj_Name = new Object[] { newObjName+"#"+preObjName };
            webBrowser_Renderer.Document.InvokeScript("updateObjectName", Obj_Name);
        }

        public void LoadObjInUnity(Object[] ObjAttributes)
        {
         //   MessageBox.Show(ObjAttributes[0].ToString());
            webBrowser_Renderer.Document.InvokeScript("LoadObject", ObjAttributes);
        }

        public void initiateWithParameters_R(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ)
        {
            // call to unity // initiateWithParameters_HTML(ObjAttributes);
            string transformationParameters = objName + "#" + positionX + "#" + positionY + "#" + positionZ + "#" + rotationX + "#" + rotationY + "#" + rotationZ + "#" + scaleX + "#" + scaleY + "#" + scaleZ;
            Object[] ObjAttributes = new Object[] { transformationParameters };
            webBrowser_Renderer.Document.InvokeScript("initiateWithParameters_HTML", ObjAttributes);
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
                UIController controller = new UIController();
                controller.setUIObjProperties(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, istrigger);
                controller.setSelectedObj(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, istrigger);
            }
            public void store_Objects(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ)
            {}
            public void resetProperty(string objName,float positionX,float positionY,float positionZ,float rotationX,float rotationY,float rotationZ,float scaleX,float scaleY,float scaleZ,bool istrigger)
            {
                new Thread(() =>
                {
                    for (int i=0;i< UIController.formMain.project.projObjects.objSelected.Count;i++)
                    {
                           if(UIController.formMain.project.projObjects.objSelected[i].ObjName.Equals(objName))
                            {
                                UIController.formMain.project.projObjects.objSelected[i].PosX = positionX;
                                UIController.formMain.project.projObjects.objSelected[i].PosY = positionY;
                                UIController.formMain.project.projObjects.objSelected[i].PosZ = positionZ;
                                UIController.formMain.project.projObjects.objSelected[i].RotX = rotationX;
                                UIController.formMain.project.projObjects.objSelected[i].RotY = rotationY;
                                UIController.formMain.project.projObjects.objSelected[i].RotZ = rotationZ;
                                UIController.formMain.project.projObjects.objSelected[i].ScaleX = scaleX;
                                UIController.formMain.project.projObjects.objSelected[i].ScaleY = scaleY;
                                UIController.formMain.project.projObjects.objSelected[i].ScaleZ = scaleZ;
                            }
                    }
                }).Start();
            }
            public void executeableCMD(string command)
            {
                if(command.Equals("loadobjects"))
                {
                    UIController controller = new UIController();
                    controller.loadProjectObjects();
                }
            }
            public void UpdateTree(string objName,float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ)
            {
                UIController controller = new UIController();
                controller.addChild(objName);
                _3DObject _object = new _3DObject(objName, objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ);
                controller.addObject(_object);
         //     controller.setUIObjProperties(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, true);
         //     controller.setSelectedObj(objName, positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ, true);
                
            }
        }
    }
}