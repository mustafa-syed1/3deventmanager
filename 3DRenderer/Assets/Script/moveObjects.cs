using UnityEngine;
using System.Collections;

public class moveObjects : MonoBehaviour {

    
	// Update is called once per frame
	void Update () {
        if(selectObject.selectedObj != null)
        {
            if (Input.GetKey("w"))
            {
                selectObject.selectedObj.transform.position += Vector3.forward * Time.deltaTime;
            }
            else if (Input.GetKey("s"))
            {
                selectObject.selectedObj.transform.position += Vector3.back * Time.deltaTime;
            }
            else if (Input.GetKey("a"))
            {
                selectObject.selectedObj.transform.position += Vector3.left * Time.deltaTime;
            }
            else if (Input.GetKey("d"))
            {
                selectObject.selectedObj.transform.position += Vector3.right * Time.deltaTime;
            }
            else if (Input.GetKey("q"))
            {
                if(selectObject.selectedObj.transform.position.y >= 0.499)
                {
                    selectObject.selectedObj.transform.position += Vector3.down * Time.deltaTime;
                }

            }
            else if (Input.GetKey("e"))
            {
                selectObject.selectedObj.transform.position += Vector3.up * Time.deltaTime;
            }
        }
    }
}
