using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

	//public float forceApplied;
	public Rigidbody rb;


	void OnCollisionEnter(Collision col)
	{
		rb = GetComponent<Rigidbody>();
		Vector3 forceApplied = rb.velocity;

		if (col.gameObject.CompareTag("Sphere"))
		{
			col.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * 50);
			col.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * -50);
		}
	}
}

