﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceP1 : MonoBehaviour {

	//public float forceApplied;
	public Rigidbody rb;

	void OnCollisionEnter(Collision col)
	{
		rb = GetComponent<Rigidbody>();
		Vector3 forceApplied = rb.velocity;

		if (col.gameObject.CompareTag("Player2"))
		{
			//col.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * 50);
			col.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * (rb.velocity.magnitude*3.5f + rb.angularVelocity.magnitude));
			col.gameObject.GetComponent<Rigidbody>().AddForce(-forceApplied* (rb.velocity.magnitude * .1f), ForceMode.Impulse);
		}
		//if (rb.velocity.magnitude > col.gameObject.GetComponent<Rigidbody>().)
	}
}

