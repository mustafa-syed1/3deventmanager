using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DInterface.core.Forms.DockableForms
{
    public class formsComunication
    {
        public static Form_Console formConsole;
        public static Form_Main formMain;
        public static ObjectsList formObject;
        public static Form_Renderer formRenderer;
        public static objApropForm objprop;

        public formsComunication(Form_Console formConsole1, Form_Main formMain1, ObjectsList formObject1, Form_Renderer formRenderer1,objApropForm objprop1)
        {
            objprop = objprop1;
            formConsole = formConsole1;
            formMain = formMain1;
            formObject = formObject1;
            formRenderer = formRenderer1;         
        }
    }
}
