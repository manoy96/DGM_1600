using UnityEngine;
using System.Collections;

public class scopeandaccessmodifier : MonoBehaviour 
{

	public int alpha = 10;

	private int beta = 0;
	private int gamma = 15;

	private anotherclass myOtherClass;

	// Use this for initialization
	void Start () 
	{

		alpha = 20;

		myOtherClass = new anotherclass ();
		myOtherClass.guns(alpha, myOtherClass.an94);

	}

	void example (int bullets, int mags)
	{
		int answer;
		answer = bullets * mags * alpha;
		Debug.Log (answer);
	}

	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("alpha is set to" + alpha);
	}
}
