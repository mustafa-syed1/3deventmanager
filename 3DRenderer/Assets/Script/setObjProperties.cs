using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setObjProperties : MonoBehaviour {

    public void setProperties(string ObjAttributes)
    {
        float posX = 0.0000f;
        float posY = 0.0000f;
        float posZ = 0.0000f;
        float rotX = 0.0000f;
        float rotY = 0.0000f;
        float rotZ = 0.0000f;
        float scaleX = 0.0000f;
        float scaleY = 0.0000f;
        float scaleZ = 0.0000f;

        string[] words1 = ObjAttributes.Split('#');
        posX = float.Parse(words1[0]);
        posY = float.Parse(words1[1]);
        posZ = float.Parse(words1[2]);
        rotX = float.Parse(words1[3]);
        rotY = float.Parse(words1[4]);
        rotZ = float.Parse(words1[5]);
        scaleX = float.Parse(words1[6]);
        scaleY = float.Parse(words1[7]);
        scaleZ = float.Parse(words1[8]);

        selectObject.selectedObj.transform.position = new Vector3(posX,posY,posZ);
        selectObject.selectedObj.transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
        selectObject.selectedObj.transform.localScale = new Vector3(scaleX,scaleY,scaleZ);

        //     Controller cntrl = new Controller();
        //     cntrl.sendProps(selectObject.selectedObj.name, selectObject.selectedObj.transform.position.x, selectObject.selectedObj.transform.position.y, selectObject.selectedObj.transform.position.z, selectObject.selectedObj.transform.eulerAngles.x, selectObject.selectedObj.transform.eulerAngles.y, selectObject.selectedObj.transform.eulerAngles.z, selectObject.selectedObj.transform.localScale.x, selectObject.selectedObj.transform.localScale.y, selectObject.selectedObj.transform.localScale.z, true);
        Application.ExternalCall("ResetProperties", selectObject.selectedObj.name, selectObject.selectedObj.transform.position.x, selectObject.selectedObj.transform.position.y, selectObject.selectedObj.transform.position.z, selectObject.selectedObj.transform.eulerAngles.x, selectObject.selectedObj.transform.eulerAngles.y, selectObject.selectedObj.transform.eulerAngles.z, selectObject.selectedObj.transform.localScale.x, selectObject.selectedObj.transform.localScale.y, selectObject.selectedObj.transform.localScale.z, true);
    }
}
