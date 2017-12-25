using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _3DInterface.core.Forms.DockableForms
{
    public class _3Dproject
    {
        public string projName { get; set; }
        public selectedObjects projObjects { get; set; }
        public string projLocation { get; set; }
        public string hallName { get; set; }
        
        public _3Dproject()
        {}

        public _3Dproject(string projName, selectedObjects projObjects, string projLocation, string hallName)
        {
            this.projName = projName;
            this.projObjects = projObjects;
            this.projLocation = projLocation;
            this.hallName = hallName;
        }

        public void save_project(_3Dproject objselt)
        {
            XmlSerializer xs = new XmlSerializer(typeof(_3Dproject));
            string path = objselt.projLocation;
            if(!path.Last().Equals('\\'))
            {
                path = path + "\\";
            }
            TextWriter tw = new StreamWriter(objselt.projLocation+objselt.projName+".xml", true);
            xs.Serialize(tw, objselt);
            tw.Close();
        }

        public _3Dproject Load_Project(string projectPath)
        {
            _3Dproject project = new _3Dproject();
            XmlSerializer serializer = new XmlSerializer(typeof(_3Dproject));
            XmlReader reader = XmlReader.Create(projectPath);
            project = (_3Dproject)serializer.Deserialize(reader);            
            return project;
        }
    }
}
