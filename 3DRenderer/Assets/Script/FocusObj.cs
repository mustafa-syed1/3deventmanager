using UnityEngine;
using System.Collections;

public class FocusObj : MonoBehaviour {

	public void FocusOnobj(string objName)
    {
        GameObject obj = GameObject.Find(objName);
        Transform transform = obj.transform;
        Vector3 pointOnside = transform.position + new Vector3(transform.localScale.x * 0.5f, 0.0f, transform.localScale.z * 0.5f);
        float aspect = (float)Screen.width / (float)Screen.height;
        float maxDistance = (transform.localScale.y * 0.5f) / Mathf.Tan(Mathf.Deg2Rad * (Camera.main.fieldOfView / aspect));
        Camera.main.transform.position = Vector3.MoveTowards(pointOnside, transform.position, -(maxDistance+1.221f));
        Camera.main.transform.LookAt(transform.position);
        selectObject.selectedObj = obj;
        ObjectProperties objProp = new ObjectProperties();
        objProp.setProperties();
    }
}
