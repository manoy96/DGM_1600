using UnityEngine;
using System.Collections;

public class foreachloop : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		string[] items = new string[3];

		items[0] = "frst item";
		items[1] = "second item";
		items[2] = "third item";

		foreach (string item in items) 
		{
			print (item);
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
