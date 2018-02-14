using UnityEngine;
using System.Collections;

public class ObjectProperties {
    string objName = "";
    float positionX = 0.0f;
    float positionY = 0.0f;
    float positionZ = 0.0f;
    float rotationX = 0.0f;
    float rotationY = 0.0f;
    float rotationZ = 0.0f;
    float scaleX = 0.0f;
    float scaleY = 0.0f;
    float scaleZ = 0.0f;
    bool istrigger = true;
    public void setProperties()
    {
        objName = selectObject.selectedObj.name;

        positionX = selectObject.selectedObj.transform.position.x;
        positionY = selectObject.selectedObj.transform.position.y;
        positionZ = selectObject.selectedObj.transform.position.z;

        rotationX = selectObject.selectedObj.transform.eulerAngles.x;
        rotationY = selectObject.selectedObj.transform.eulerAngles.y;
        rotationZ = selectObject.selectedObj.transform.eulerAngles.z;

        scaleX = selectObject.selectedObj.transform.localScale.x;
        scaleY = selectObject.selectedObj.transform.localScale.y;
        scaleZ = selectObject.selectedObj.transform.localScale.z;

        Controller ctrl = new Controller();
        ctrl.sendProps(this.objName,this.positionX,this.positionY,this.positionZ,this.rotationX,this.rotationY,this.rotationZ,this.scaleX,this.scaleY,this.scaleZ,this.istrigger);
    }
}
