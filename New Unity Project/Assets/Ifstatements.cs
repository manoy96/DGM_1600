using UnityEngine;
using System.Collections;

public class Ifstatements : MonoBehaviour 
{
	float watertemp = 230f;
	float boil = 212f;
	float freeze = 32f;

	//This is the test of my new scripts in my branch
	// Use this for initialization
	void Start ()
	{

	}
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (transform.position.y);

		if(Input.GetKeyDown(KeyCode.Space))
			
			test();

		watertemp -= Time.deltaTime * 4f;
	}
	void test()
	{
		//if the water's temperature reaches too high temp
		if(watertemp > boil)
		{
			//if too hot display 'AHHH it's too HOT!'
			print("AHHH it's too HOT!");
		}
		else if(watertemp < freeze)
		{
			//if too cold display 'AHHH I love popsicles!'
			print("AHHH I love popsicles!");
		}
		else
		{
			//If the value is neither too big or too small
			print("It's just right");
		}
}
}