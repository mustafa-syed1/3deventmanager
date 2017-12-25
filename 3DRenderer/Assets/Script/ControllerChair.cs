using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerChair : MonoBehaviour {

    public Text instruction;
    public GameObject Chair;
    public GameObject chair2;
    public GameObject chair3;
    public GameObject chair4;
    public GameObject chair5;
    public GameObject chair6;
    void ChangeIt(string word)
    {
        //var boxCollider = Table.AddComponent<BoxCollider> ();
        //boxCollider.center = new Vector3 (2, 3, 4);
        createObjects(word);
    }
    // Use this for initialization
    void createObjects(string word)
    {
        BoxCollider boxCollider;
        Bounds bounds;
        MeshFilter[] filters;
        if (word.Equals("chair1.PNG"))
        {
            Chair.AddComponent<BoxCollider>();
            boxCollider = (BoxCollider)Chair.GetComponent<Collider>();
            bounds = new Bounds(Vector3.zero, Vector3.zero);

            filters = Chair.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter f in filters)
            {
                bounds.Encapsulate(f.sharedMesh.bounds);
                bounds.center = Vector3.zero;
            }
            boxCollider.size = bounds.size;
            boxCollider.center = bounds.center;
            instruction.text = word;

            //Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //Table.transform.position = new Vector3(0, 0.5F, 0);
            Instantiate(Chair, transform.position, transform.rotation);
        }
        else if (word.Equals("chair3.jpg"))
        {
            chair3.AddComponent<BoxCollider>();
            boxCollider = (BoxCollider)chair3.GetComponent<Collider>();
            bounds = new Bounds(Vector3.zero, Vector3.zero);

            filters = chair3.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter f in filters)
            {
                bounds.Encapsulate(f.sharedMesh.bounds);
                bounds.center = Vector3.zero;
            }
            boxCollider.size = bounds.size;
            boxCollider.center = bounds.center;
            instruction.text = word;
            //Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //Table.transform.position = new Vector3(0, 0.5F, 0);
            Instantiate(chair3, transform.position, transform.rotation);
        }
        else if (word.Equals("chair2.PNG"))
        {
            chair2.AddComponent<BoxCollider>();
            boxCollider = (BoxCollider)chair2.GetComponent<Collider>();
            bounds = new Bounds(Vector3.zero, Vector3.zero);

            filters = chair2.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter f in filters)
            {
                bounds.Encapsulate(f.sharedMesh.bounds);
                bounds.center = Vector3.zero;
            }
            boxCollider.size = bounds.size;
            boxCollider.center = bounds.center;
            instruction.text = word;
            //Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //Table.transform.position = new Vector3(0, 0.5F, 0);
            Instantiate(chair2, transform.position, transform.rotation);

        }
        else if (word.Equals("chair4.PNG"))
        {
            chair4.AddComponent<BoxCollider>();
            boxCollider = (BoxCollider)chair4.GetComponent<Collider>();
            bounds = new Bounds(Vector3.zero, Vector3.zero);

            filters = chair4.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter f in filters)
            {
                bounds.Encapsulate(f.sharedMesh.bounds);
                bounds.center = Vector3.zero;
            }
            boxCollider.size = bounds.size;
            boxCollider.center = bounds.center;
            instruction.text = word;
            //Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //Table.transform.position = new Vector3(0, 0.5F, 0);
            Instantiate(chair4, transform.position, transform.rotation);

        }
        else if (word.Equals("chair5.PNG"))
        {
            chair5.AddComponent<BoxCollider>();
            boxCollider = (BoxCollider)chair5.GetComponent<Collider>();
            bounds = new Bounds(Vector3.zero, Vector3.zero);

            filters = chair5.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter f in filters)
            {
                bounds.Encapsulate(f.sharedMesh.bounds);
                bounds.center = Vector3.zero;
            }
            boxCollider.size = bounds.size;
            boxCollider.center = bounds.center;
            instruction.text = word;
            //Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //Table.transform.position = new Vector3(0, 0.5F, 0);
            Instantiate(chair5, transform.position, transform.rotation);
        }
        else if (word.Equals("chair6.PNG"))
        {
            chair6.AddComponent<BoxCollider>();
            boxCollider = (BoxCollider)chair6.GetComponent<Collider>();
            bounds = new Bounds(Vector3.zero, Vector3.zero);

            filters = chair6.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter f in filters)
            {
                bounds.Encapsulate(f.sharedMesh.bounds);
                bounds.center = Vector3.zero;
            }
            boxCollider.size = bounds.size;
            boxCollider.center = bounds.center;
            instruction.text = word;
            //Table = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            //Table.transform.position = new Vector3(0, 0.5F, 0);
            Instantiate(chair6, transform.position, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

}
