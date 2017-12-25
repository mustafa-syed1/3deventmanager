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

        public List<_3DObject> return_objSelected()
        {
            return this.objSelected;
        }

        public int return_objCount()
        {
            return this.objCount;
        }
    }
}
