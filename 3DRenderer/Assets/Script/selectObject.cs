using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class selectObject : MonoBehaviour {

    public static GameObject selectedObj;
    public GameObject selectedObjBoundry;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if(hit.transform.gameObject.name.Equals("floor"))
                {
                    this.selectedObjBoundry.SetActive(false);
                    selectedObj = null;
                    Controller cntrl = new Controller();
                    cntrl.sendProps("", 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, false);
                }
                else
                {
                    
                    selectedObj = hit.transform.gameObject;
                    Debug.Log(hit.transform.gameObject.name);
                    ObjectProperties prop = new ObjectProperties();
                    prop.setProperties();
                    performOutline();
                }
            }
            else
            {
                this.selectedObjBoundry.SetActive(false);
                selectedObj = null;
                Controller cntrl = new Controller();
                cntrl.sendProps("",0.0f,0.0f,0.0f,0.0f,0.0f,0.0f,0.0f,0.0f,0.0f,false);
            }
        }
    }
    public void performOutline()
    {
        BoxCollider collider = selectedObj.transform.gameObject.GetComponent<BoxCollider>();
        this.selectedObjBoundry.SetActive(true);
        this.selectedObjBoundry.transform.position = new Vector3(selectedObj.transform.position.x , selectedObj.transform.position.y + collider.center.y/3.0f, selectedObj.transform.position.z + collider.center.z / 3.0f);
        this.selectedObjBoundry.transform.localScale = new Vector3(collider.size.x*selectedObj.transform.localScale.x, collider.size.y * selectedObj.transform.localScale.y, collider.size.z * selectedObj.transform.localScale.z);
    }
}
