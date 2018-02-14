using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DInterface.core.Forms.DockableForms
{
    public class currentSelectedObject
    {
        public _3DObject SelectedObj { get; set; }

        public currentSelectedObject()
        {
            SelectedObj = new _3DObject();
        }

        public void UpdateObjName(string newObjName, string preObjName)
        {
            SelectedObj.ObjName = newObjName;
        }
    }
}