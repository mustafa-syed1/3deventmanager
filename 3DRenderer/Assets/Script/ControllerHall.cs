using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerHall : MonoBehaviour {

	public Text instruction;
	public GameObject secondHall;
	// Use this for initialization
	void ChangeIt(string word)
	{
		instruction.text = word;
		createObjects(word);
	}

	void createObjects(string word)
	{
		if (word.Equals ("hall1.jpg")) 
		{
			Instantiate (secondHall, transform.position, transform.rotation);

		}

	}

	// Update is called once per frame
	void Update () {
	
	}
}
