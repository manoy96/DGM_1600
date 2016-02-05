using UnityEngine;
using System.Collections;

public class foreachloop : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		string[] strings = new string[3];

		strings[0] = "string1";
		strings[1] = "string2";
		strings[2] = "string3";

		foreach (string item in strings) 
		{
			print (item);
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
