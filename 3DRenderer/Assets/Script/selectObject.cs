using UnityEngine;
using System.Collections;

public class selectObject : MonoBehaviour {

    public static GameObject selectedObj;
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
                    selectedObj = null;
                }
                else
                {
                    selectedObj = hit.transform.gameObject;
                    Debug.Log(hit.transform.gameObject.name);
                }


            }
        }
    }
}
