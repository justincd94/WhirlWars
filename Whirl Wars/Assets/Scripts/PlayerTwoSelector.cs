using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoSelector : MonoBehaviour {

    public static GameObject player2;

    public void SelectCharacters(GameObject go)
    {
        player2 = go;
        //go.gameObject.tag = "Player2";
    }
}
