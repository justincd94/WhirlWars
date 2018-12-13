using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirlWars : MonoBehaviour {

    public GameObject p1;
    public GameObject p2;
    //public GameObject p1winText;
    //public GameObject p2winText;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;

    // Use this for initialization
    void Start () {

        //SetP1(p1);
        //SetP2(p2);

        p1 = CharacterPicker.player1;
        p1.transform.position = new Vector3(4, 2, 0);
        GameObject player1 = Instantiate<GameObject>(p1);
        

        p2 = PlayerTwoSelector.player2;
        p2.transform.position = new Vector3(-4, 2, 0);
        GameObject player2 = Instantiate<GameObject>(p2);
        

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
            //RespawnP1();
            Respawn();
        }

        if (GameObject.FindWithTag("Player2") == null)
        {
            //RespawnP2();
            Respawn();
        }

        /*if (GameObject.FindGameObjectsWithTag("Player").Length < 2)
        {
            Respawn();
        }*/
    }

    /*void RespawnP1 ()
    {
        GameObject player1 = Instantiate<GameObject>(p1);
        p1.transform.position = new Vector3 (4, 2, 0);
    }

    void RespawnP2 ()
    {
        GameObject player2 = Instantiate<GameObject>(p2);
        p2.transform.position = new Vector3(-4, 2, 0);
    }*/

    void Respawn()
    {
        GameObject player1 = Instantiate<GameObject>(p1);
        p1.transform.position = new Vector3(4, 2, 0);

        GameObject player2 = Instantiate<GameObject>(p2);
        p2.transform.position = new Vector3(-4, 2, 0);

    }

    /*public void P1Win()
    {
        p1winText.SetActive(true);
        //have rematch and character select or stage select buttons appear
    }

    public void P2Win()
    {
        p2winText.SetActive(true);
        //have rematch and character select or stage select buttons appear
    }*/

    void SetP1(GameObject go)
    {
        p1 = go;
    }

    void SetP2(GameObject go)
    {
        p2 = go;
    }
}
