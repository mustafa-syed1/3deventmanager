using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Controller : MonoBehaviour {
    public Text instruction;
    public GameObject cylinder;
    public GameObject sofa;
    public GameObject table;
    
    void ChangeIt(string word)
    {
        instruction.text = word;
        createObjects(word);
    }

    void createObjects(string word)
    {
        if (word.Equals("00"))
        {
            Instantiate(cylinder, transform.position, transform.rotation);
        }
        if (word.Equals("01"))
        {
            Instantiate(sofa, transform.position, transform.rotation);
        }
        if (word.Equals("02"))
        {
            Instantiate(table, transform.position, transform.rotation);
        }
    }

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
}
