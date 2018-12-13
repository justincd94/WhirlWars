using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceP1 : MonoBehaviour {

	//public float forceApplied;
	public Rigidbody rb;
    private AudioSource clashSound;
    public AudioClip[] clashes;
    private AudioClip clashClip;

    void Start()
    {
        clashSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
	{
		rb = GetComponent<Rigidbody>();
		Vector3 forceApplied = rb.velocity;

		if (col.gameObject.CompareTag("Player2"))
		{
            int index = Random.Range(0, clashes.Length);
            clashClip = clashes[index];
            clashSound.clip = clashClip;
            clashSound.Play();
			col.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * 50);
			col.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * (rb.velocity.magnitude*3.5f + rb.angularVelocity.magnitude));
			col.gameObject.GetComponent<Rigidbody>().AddForce(-forceApplied* (rb.velocity.magnitude * .1f), ForceMode.Impulse);
		}
		//if (rb.velocity.magnitude > col.gameObject.GetComponent<Rigidbody>().)
	}
}

