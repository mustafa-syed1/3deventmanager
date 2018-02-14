using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime *200;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
			transform.position -= transform.right * Time.deltaTime *200;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
			transform.position += transform.forward * Time.deltaTime *200;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
			transform.position -= transform.forward * Time.deltaTime*200;
        }

    }
}
