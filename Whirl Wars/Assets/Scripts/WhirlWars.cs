﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlWars : MonoBehaviour {

    public GameObject p1;
    public GameObject p2;

	// Use this for initialization
	void Start () {

        GameObject player1 = Instantiate<GameObject>(p1);
        p1.transform.position = new Vector3(4, 2, 0);

        GameObject player2 = Instantiate<GameObject>(p2);
        p2.transform.position = new Vector3(-4, 2, 0);

        Invoke("CheckIfExists", 1.5f);
    }
	
	// Update is called once per frame
	void Update () {
        CheckIfExists(.1f);
	}

    void CheckIfExists (float delay)
    {
        if (GameObject.FindWithTag("Player") == null)
        {
            RespawnP1();
        }

        if (GameObject.FindWithTag("Player2") == null)
        {
            RespawnP2();
        }
    }

    void RespawnP1 ()
    {
        GameObject player1 = Instantiate<GameObject>(p1);
        p1.transform.position = new Vector3 (4, 2, 0);
    }

    void RespawnP2 ()
    {
        GameObject player2 = Instantiate<GameObject>(p2);
        p2.transform.position = new Vector3(-4, 2, 0);
    }
}