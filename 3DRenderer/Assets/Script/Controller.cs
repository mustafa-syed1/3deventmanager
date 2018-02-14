using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Controller : MonoBehaviour {

    void Start()
    {
        
        // Unity is just Loaded //
        Application.ExternalCall("executeableCMDs", "loadobjects");
    }
    void ChangeIt(string word)
    {}
    public void deleteObj(string word)
    {
        if(selectObject.selectedObj != null)
        {
	            Destroy(selectObject.selectedObj);
        }
    }
    public void sendProps(string objName, float positionX, float positionY, float positionZ, float rotationX, float rotationY, float rotationZ, float scaleX, float scaleY, float scaleZ, bool istrigger)
    {
        Debug.Log(objName+" "+positionX+" "+positionY+" "+positionZ+" "+rotationX+" "+rotationY+" "+rotationZ+" "+scaleX+" "+scaleY+" "+scaleZ+" "+istrigger);
        Application.ExternalCall("ObjectProperties", objName,positionX,positionY,positionZ,rotationX,rotationY,rotationZ,scaleX,scaleY,scaleZ, istrigger);
    }

    public void updateObjName(string objNames)
    {
        string[] names = objNames.Split('#');
        GameObject obj = GameObject.Find(names[1]);
        obj.name = names[0];
    }
}
