using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DInterface.core.Forms.DockableForms
{
    public class _3DObject
    {
        private string objName;
        private string objID;
        private double posX;
        private double posY;
        private double posZ;
        private double rotX;
        private double rotY;
        private double rotZ;
        private double scaleX;
        private double scaleY;
        private double scaleZ;

        public _3DObject() {
            this.objName = "Obj1";
            this.ObjID = "Obj";
            this.posX = 2.3;
            this.posY = 3.4;
            this.posZ = 2.3;
            this.rotX = 1.2;
            this.rotY = 2.5;
            this.rotZ = 4.5;
            this.scaleX = 3.2;
            this.scaleY = 1.2;
            this.scaleZ = 2.3;
        }
        public _3DObject(string objName, string objID, double posX, double posY, double posZ, double rotX, double rotY, double rotZ, double scaleX, double scaleY, double scaleZ)
        {
            this.ObjName = objName;
            this.ObjID = objID;
            this.PosX = posX;
            this.PosY = posY;
            this.PosZ = posZ;
            this.RotX = rotX;
            this.RotY = rotY;
            this.RotZ = rotZ;
            this.ScaleX = scaleX;
            this.ScaleY = scaleY;
            this.ScaleZ = scaleZ;
        }

        public string ObjName
        {
            get
            {
                return objName;
            }

            set
            {
                objName = value;
            }
        }
        public string ObjID
        {
            get
            {
                return objID;
            }

            set
            {
                objID = value;
            }
        }
        public double PosX
        {
            get
            {
                return posX;
            }

            set
            {
                posX = value;
            }
        }
        public double PosY
        {
            get
            {
                return posY;
            }

            set
            {
                posY = value;
            }
        }
        public double PosZ
        {
            get
            {
                return posZ;
            }

            set
            {
                posZ = value;
            }
        }
        public double RotX
        {
            get
            {
                return rotX;
            }

            set
            {
                rotX = value;
            }
        }
        public double RotY
        {
            get
            {
                return rotY;
            }

            set
            {
                rotY = value;
            }
        }
        public double RotZ
        {
            get
            {
                return rotZ;
            }

            set
            {
                rotZ = value;
            }
        }
        public double ScaleX
        {
            get
            {
                return scaleX;
            }

            set
            {
                scaleX = value;
            }
        }
        public double ScaleY
        {
            get
            {
                return scaleY;
            }

            set
            {
                scaleY = value;
            }
        }
        public double ScaleZ
        {
            get
            {
                return scaleZ;
            }

            set
            {
                scaleZ = value;
            }
        }
        
    }
}
