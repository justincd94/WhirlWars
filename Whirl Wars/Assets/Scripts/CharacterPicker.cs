using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPicker : MonoBehaviour {

    public static GameObject player1;
    public static GameObject player2;

    public void SelectCharacters (GameObject go)
    {
        player1 = go;
        //go.gameObject.tag = "Player";
    }
}
