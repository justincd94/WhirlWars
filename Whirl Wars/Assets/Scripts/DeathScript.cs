using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player2"));
        }

        if (col.gameObject.tag == "Player2")
        {
            Destroy(col.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }
}
