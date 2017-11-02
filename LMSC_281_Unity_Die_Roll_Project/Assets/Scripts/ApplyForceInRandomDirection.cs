//example provided by http://www.cookingwithunity.com/

using UnityEngine;
using System.Collections;

public class ApplyForceInRandomDirection : MonoBehaviour
// this is the script to apply force to and roll the die
{
	public string buttonName = "Fire1";
	// when the mouse is clicked it triggers the force
	public float forceAmount = 10.0f;
	public float torqueAmount = 10.0f;
	// these set how high the force is
	public ForceMode forceMode;

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButtonDown(buttonName))
			//if the mouse is clicked this is true and we apply force
		{
			GetComponent<Rigidbody>().AddForce(Random.onUnitSphere*forceAmount,forceMode);
			GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere*torqueAmount,forceMode);
			//when there is a click a random force is applied to the die
		}
	}
}
