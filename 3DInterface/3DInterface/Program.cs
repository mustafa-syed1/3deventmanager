using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3DInterface.core.Forms.DockableForms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace _3DInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        

        static void Main()
        {
                   Application.EnableVisualStyles();
                   Application.SetCompatibleTextRenderingDefault(false);
                   Application.Run(new Wellcome());
/*            
            System.Console.WriteLine("1)Save Project\n2)Load Project");
            int a = int.Parse(System.Console.ReadLine());
            if(a == 1)
            {
                _3DObject o1 = new _3DObject();
                _3DObject o2 = new _3DObject();
                _3DObject o3 = new _3DObject();

                selectedObjects objselt = new selectedObjects();
                objselt.addObject(o1);
                objselt.addObject(o2);
                objselt.addObject(o3);

                SaveProject proj = new SaveProject();
                proj.save_project(objselt);
            }
            else if(a == 2)
            {
                LoadProject ldpj = new LoadProject();
                selectedObjects objselt = new selectedObjects();
                objselt = ldpj.Load_Project("BigBangggg");
                List<_3DObject> projObj = objselt.return_objSelected();

                foreach(_3DObject obj in projObj)
                {
                    System.Console.WriteLine(obj.ObjName +"   "+ obj.PosX);
                }
                System.Console.ReadLine();
            }
*/        }
    }
}
