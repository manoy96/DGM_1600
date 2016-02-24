using UnityEngine;
using System.Collections;

public class dowhileloop : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	/* bool is a true/false define statement
	 * can set to false, and when the statement becomes
	 * true, it will output a value or anwser.*/

		bool continueforward = false;

		do
		{
			print("This script works!");
		
		}
		while(continueforward == true);

	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}
