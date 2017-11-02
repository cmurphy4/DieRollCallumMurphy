//example provided by http://www.cookingwithunity.com/

using UnityEngine;
using System.Collections;

public class SetMaxAngularVelocity : MonoBehaviour
{
	public float maxAngularVelocity = 7.0f;
	//set the velocity of the rotation of the die?

	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody>().maxAngularVelocity = maxAngularVelocity;
		// stops the die spinning too rapidly?
	}
}
