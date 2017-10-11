using UnityEngine;
using System.Collections;

public class ZoomInOutCamera : MonoBehaviour {
    
	void Update () {
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            if(transform.position.y >= 0.1643)
            {
                transform.position += Vector3.down * Time.deltaTime;
            }
            
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
    }
}
