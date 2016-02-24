using UnityEngine;
using System.Collections;

public class Whileloop : MonoBehaviour 
{

	int nEnemies = 0;

	// Use this for initialization
	void Start () 
	{
		while (nEnemies < 5) 
		{
			Debug.Log ("Enemy is down");
			nEnemies++;
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
