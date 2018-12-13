using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

	public Scoreboard scoreboard;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player2"));
			scoreboard.AddScoreP2();
            // give a point to p2
        }

        if (col.gameObject.tag == "Player2")
        {
            Destroy(col.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player"));
			scoreboard.AddScoreP1();
            // give a point to p1
        }
    }

}
