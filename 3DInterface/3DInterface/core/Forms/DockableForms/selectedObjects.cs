using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DInterface.core.Forms.DockableForms
{
    public class selectedObjects
    {
        public List<_3DObject> objSelected = new List<_3DObject>();
        private int objCount;
        public selectedObjects() { }

        public void addObject(_3DObject obj)
        {
            this.objSelected.Add(obj);
            ++this.objCount;
        }

        public void removeObject(string objName)
        {
            List<_3DObject> selectedObj = new List<_3DObject>();
            foreach (_3DObject obj in objSelected)
            {
                if(!obj.ObjName.Equals(objName))
                {
                    selectedObj.Add(obj);
                }
            }
            this.objSelected = new List<_3DObject>();
            this.objCount = 0;

            foreach (_3DObject obj in selectedObj)
            {
                this.addObject(obj);
            }

        }
        public List<_3DObject> return_objSelected()
        {
            return this.objSelected;
        }
        public int return_objCount()
        {
            return this.objCount;
        }

        public void UpdateObjName(string newObjName, string preObjName)
        {
            for(int i=0;i<objSelected.Count;i++)
            {
                if(objSelected[i].ObjName.ToString().Equals(preObjName))
                {
                    objSelected[i].ObjName = newObjName;
                    return;
                }
            }
        }

        public bool isNotValidObjName(string newObjName)
        {
            bool result = false;
            for (int i = 0; i < objSelected.Count; i++)
            {
                if (objSelected[i].ObjName.ToString().Equals(newObjName))
                {
                    result = true;
                }
            }
            return result;
        }
    }
}