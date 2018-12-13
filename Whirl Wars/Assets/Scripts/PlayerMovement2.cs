/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

	public PlayerMovement2 Player2;

	public KeyCode left;
	public KeyCode right;
	public KeyCode up;
	public KeyCode down;
	public KeyCode space;


	private void Start()
	{
		rb = GetComponent<Rigidbody>();

	}

	public float speed = 25.0f;
	public Rigidbody rb;




	//Player 2 Code with aswd keys
	void Player2Movement()
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


		Player2Movement();

	}
}*/

using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement2 : MonoBehaviour

{



    public PlayerMovement2 Player2;

    public GameObject particle;



    public KeyCode left;

    public KeyCode right;

    public KeyCode up;

    public KeyCode down;

    public KeyCode burst;



    public float speed = 25.0f;

    public Rigidbody rb;

    public ParticleSystem ps;



    public float boostCooldown = 4f;

    private bool hasCooldown;



    private ParticleSystem[] particles = new ParticleSystem[4];



    private void Start()

    {

        rb = GetComponent<Rigidbody>();

        var em = ps.emission;

        em.enabled = false;



        int i = 0;

        foreach (Transform child in transform)

        {

            particles[i] = child.gameObject.GetComponent<ParticleSystem>();

            i++;

        }



    }





    //Player 2 Code with aswd keys

    void Player2Movement()

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

    //            if (other.gameObject.CompareTag("PickUp"))

    //            {

    //                            other.gameObject.SetActive(false);





    //            }



    //}





    void Update()

    {



        /*if (Input.GetKeyDown("space") && GetComponent<Rigidbody>().transform.position.y <= 0.5f)

        {

            Vector3 jump = new Vector3(0.0f, 275f, 0.0f);

            GetComponent<Rigidbody>().AddForce(jump);

        }





        if (Input.GetKeyDown("/") && GetComponent<Rigidbody>().transform.position.y <= 0.5f)

        {

            Vector3 jump = new Vector3(0.0f, 275f, 0.0f);

            GetComponent<Rigidbody>().AddForce(jump);

        }*/





        Player2Movement();



        if (Input.GetKeyDown(burst) && !hasCooldown)

        {

            rb.AddForce(rb.velocity.normalized * 1000);



            StartCoroutine(ActivateCooldown());

            StopParticles();

        }





    }





    IEnumerator ActivateCooldown()

    {

        hasCooldown = true;



        yield return new WaitForSeconds(boostCooldown);



        StartParticles();

        hasCooldown = false;

    }



    private void StopParticles()

    {

        foreach (ParticleSystem ps in particles)

            ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

    }



    private void StartParticles()

    {

        foreach (ParticleSystem ps in particles)

            ps.Play();



    }

}
