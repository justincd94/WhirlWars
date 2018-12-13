using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour {

    private AudioSource aSource;
    public AudioClip[] clash;
    private AudioClip clashClip;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ClickHandler");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        aSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            int index = Random.Range(0, clash.Length);
            clashClip = clash[index];
            aSource.clip = clashClip;
            aSource.Play();
        }
	}

    /*private void OnCollisionEnter(Collision col)
    {
        int index = Random.Range(0, clash.Length);
        clashClip = clash[index];
        aSource.clip = clashClip;
        aSource.Play();
    }*/
}
