using UnityEngine;
using System.Collections;

public class forloop : MonoBehaviour {
	int nEnemies = 20;

	// Use this for initialization
	void Start () {
		/* We are creating the for loop. we use ';' between
		 * the 'for' loop*/
		for (int i = 0; i < nEnemies; i++) 
		{
			Debug.Log ("create the number of enemies:" + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
