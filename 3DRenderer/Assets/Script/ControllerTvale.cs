using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerTvale : MonoBehaviour {

	public Text instruction;
	public GameObject Table;
	void ChangeIt(string word)
	{
		//var boxCollider = Table.AddComponent<BoxCollider> ();
		//boxCollider.center = new Vector3 (2, 3, 4);

		Table.AddComponent<BoxCollider> ();
		BoxCollider boxCollider = (BoxCollider)Table.GetComponent<Collider>(); 
		Bounds bounds = new Bounds (Vector3.zero , Vector3.zero);

		MeshFilter[] filters = Table.GetComponentsInChildren<MeshFilter> ();
		foreach (MeshFilter f in filters) {
			bounds.Encapsulate (f.sharedMesh.bounds);
			bounds.center = Vector3.zero;
		}
		boxCollider.size = bounds.size;
		boxCollider.center = bounds.center;
		instruction.text = word;
		createObjects(word);
	}

	// Use this for initialization
	void createObjects(string word)
	{
		if (word.Equals ("sofa.PNG")) 
		{
			//Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//Table.transform.position = new Vector3(0, 0.5F, 0);
			Instantiate(Table, transform.position, transform.rotation);
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
