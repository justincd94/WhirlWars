using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuousMusic : MonoBehaviour { 

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 4 || scene.buildIndex == 5 || scene.buildIndex == 6)
        {
            Destroy(this.gameObject);
        }
    }
}
