using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReturnSelectedObj : MonoBehaviour {

	public void returnSelectedObj(string command)
    {
        List<GameObject> allParentObjects = getSelectedObj();

        print("Total Parent Objects : " + allParentObjects.Count);
        foreach (GameObject go in allParentObjects)
        {
            //        print("Name : " + go.name.ToString() + "   X : " + go.transform.position.x.ToString() + "    Y : " + go.transform.position.y.ToString() + "    Z : " + go.transform.position.z.ToString());
            Application.ExternalCall("storeObjects",go.name.ToString(),go.transform.position.x,go.transform.position.y,go.transform.position.z, go.transform.rotation.x, go.transform.rotation.y, go.transform.rotation.z,go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z);
        }
    }

    
    public List<GameObject> getSelectedObj()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        print("Total Objects : " + allObjects.Length);
        List<GameObject> allParentObjects = new List<GameObject>();
         
        foreach (GameObject go in allObjects)
        {
            if(!allParentObjects.Contains(go.transform.root.gameObject))
            {
                if(go.name != "Main Camera" && go.name != "floor" && go.name != "Directional Light" && go.name != "floor" && go.name != "runner" && go.name != "Canvas" && go.name != "Text" && go.name != "EventSystem")
                {
                    allParentObjects.Add(go.transform.root.gameObject);
                }
            }            
        }
        return allParentObjects;
    }
}