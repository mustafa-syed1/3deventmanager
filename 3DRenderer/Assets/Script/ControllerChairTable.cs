using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerChairTable : MonoBehaviour {

	public Text instruction;
	public GameObject ChairTable;
	public GameObject ChairTable2;
	public GameObject ChairTable3;
	public GameObject ChairTable4;
	public GameObject ChairTable5;
	void ChangeIt(string word)
	{
		//var boxCollider = Table.AddComponent<BoxCollider> ();
		//boxCollider.center = new Vector3 (2, 3, 4);

		createObjects(word);
	}
	// Use this for initialization
	void createObjects(string word)
	{
		MeshFilter[] filters;
		Bounds bounds;
		BoxCollider boxCollider;
		if (word.Equals ("square.png")) 
		{
			ChairTable.AddComponent<BoxCollider> ();
			boxCollider = (BoxCollider)ChairTable.GetComponent<Collider>(); 
			bounds = new Bounds (Vector3.zero , Vector3.zero);

			filters = ChairTable.GetComponentsInChildren<MeshFilter> ();
			foreach (MeshFilter f in filters) {
				bounds.Encapsulate (f.sharedMesh.bounds);
				bounds.center = Vector3.zero;

			}
			boxCollider.size = bounds.size;
			boxCollider.center = bounds.center;

			instruction.text = word;
			//Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//Table.transform.position = new Vector3(0, 0.5F, 0);
			Instantiate(ChairTable, transform.position, transform.rotation);
		}
		else if (word.Equals ("chairTable2.jpg")) 
		{
			ChairTable2.AddComponent<BoxCollider> ();
			boxCollider = (BoxCollider)ChairTable2.GetComponent<Collider>(); 
			bounds = new Bounds (Vector3.zero , Vector3.zero);

			filters = ChairTable2.GetComponentsInChildren<MeshFilter> ();
			foreach (MeshFilter f in filters) {
				bounds.Encapsulate (f.sharedMesh.bounds);
				bounds.center = Vector3.zero;
			}
			boxCollider.size = bounds.size;
			boxCollider.center = bounds.center;
			instruction.text = word;
			//Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//Table.transform.position = new Vector3(0, 0.5F, 0);
			Instantiate(ChairTable2, transform.position, transform.rotation);
		}
		else if (word.Equals ("chairTable3.jpg")) 
		{
			ChairTable3.AddComponent<BoxCollider> ();
			boxCollider = (BoxCollider)ChairTable3.GetComponent<Collider>(); 
			bounds = new Bounds (Vector3.zero , Vector3.zero);

			filters = ChairTable3.GetComponentsInChildren<MeshFilter> ();
			foreach (MeshFilter f in filters) {
				bounds.Encapsulate (f.sharedMesh.bounds);
				bounds.center = Vector3.zero;
			}
			boxCollider.size = bounds.size;
			boxCollider.center = bounds.center;
			instruction.text = word;
			//Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//Table.transform.position = new Vector3(0, 0.5F, 0);
			Instantiate(ChairTable3, transform.position, transform.rotation);
		}
		else if (word.Equals ("chairTable4.jpg")) 
		{
			ChairTable4.AddComponent<BoxCollider> ();
			boxCollider = (BoxCollider)ChairTable4.GetComponent<Collider>(); 
			bounds = new Bounds (Vector3.zero , Vector3.zero);

			filters = ChairTable4.GetComponentsInChildren<MeshFilter> ();
			foreach (MeshFilter f in filters) {
				bounds.Encapsulate (f.sharedMesh.bounds);
				bounds.center = Vector3.zero;
			}
			boxCollider.size = bounds.size;
			boxCollider.center = bounds.center;
			instruction.text = word;
			//Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//Table.transform.position = new Vector3(0, 0.5F, 0);
			Instantiate(ChairTable4, transform.position, transform.rotation);
		}
		else if (word.Equals ("chairTable5.jpg")) 
		{
			ChairTable5.AddComponent<BoxCollider> ();
			boxCollider = (BoxCollider)ChairTable5.GetComponent<Collider>(); 
			bounds = new Bounds (Vector3.zero , Vector3.zero);

			filters = ChairTable5.GetComponentsInChildren<MeshFilter> ();
			foreach (MeshFilter f in filters) {
				bounds.Encapsulate (f.sharedMesh.bounds);
				bounds.center = Vector3.zero;
			}
			boxCollider.size = bounds.size;
			boxCollider.center = bounds.center;
			instruction.text = word;
			//Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			//Table.transform.position = new Vector3(0, 0.5F, 0);
			Instantiate(ChairTable5, transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
