using UnityEngine;
using System.Collections;

public class datatypes : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//reference variable
		Transform tran = transform;
		tran.position = new Vector3 (2, 3, 0);

		//value variable
		Vector3 pos = transform.position;
		pos = new Vector3 (1, 2, 3);



	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
