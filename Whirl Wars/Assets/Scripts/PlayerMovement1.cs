﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour {

	public PlayerMovement1 Player1;

	public KeyCode left;
	public KeyCode right;
	public KeyCode up;
	public KeyCode down;


	private void Start()
	{
		rb = GetComponent<Rigidbody>();

	}

	public float speed = 80.0f;
	public Rigidbody rb;




	//Player 1 Code with aswd keys
	void Player1Movement()
	{
		if (Input.GetKey(left))
		{
			rb.AddForce(Vector3.left * speed);
		}

		if (Input.GetKey(right))
		{
			rb.AddForce(Vector3.right * speed);
		}

		if (Input.GetKey(up))
		{
			rb.AddForce(Vector3.forward * speed);
		}

		if (Input.GetKey(down))
		{
			rb.AddForce(Vector3.back * speed);
		}
	}




	//void OnTriggerEnter(Collider other)
	//{
	//	if (other.gameObject.CompareTag("PickUp"))
	//	{
	//		other.gameObject.SetActive(false);
	
	
	//	}

	//}


	void Update()
	{

		if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= 0.5f)
		{
			Vector3 jump = new Vector3(0.0f, 275f, 0.0f);
			GetComponent<Rigidbody>().AddForce(jump);
		}


		if (Input.GetKeyDown("/") && GetComponent<Rigidbody>().transform.position.y <= 0.5f)
		{
			Vector3 jump = new Vector3(0.0f, 275f, 0.0f);
			GetComponent<Rigidbody>().AddForce(jump);
		}


		Player1Movement();

	}
}