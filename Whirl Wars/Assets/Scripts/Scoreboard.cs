using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

	private int p1Score;
	private int p2Score;

	public Text scoreText1;
	public Text scoreText2;
    public GameObject p1WinText;
    public GameObject p2WinText;
    public GameObject rematchButton;
    public GameObject startMenuButton;

	// Use this for initialization
	void Start () {
		p1Score = 0;
		p2Score = 0;
	}

    private void Update()
    {
        if (p1Score >= 10)
        {
            P1Win();
        }

        if (p2Score >= 10)
        {
            P2Win();
        }
    }

    public void AddScoreP1()
	{
        
        p1Score += 1;
		UpdateScoreP1();
        
	}

	public void AddScoreP2()
	{
        
        p2Score += 1;
		UpdateScoreP2();
        
	}

	void UpdateScoreP1()
	{
		scoreText1.text = "Player One: " + p1Score;
	}

	void UpdateScoreP2()
	{
		scoreText2.text = "Player Two: " + p2Score;
	}

    void P1Win()
    {
        p1WinText.SetActive(true);
        //have rematch and character select or stage select buttons appear
        rematchButton.SetActive(true);
        startMenuButton.SetActive(true);
    }

    void P2Win()
    {
        p2WinText.SetActive(true);
        //have rematch and character select or stage select buttons appear
        rematchButton.SetActive(true);
        startMenuButton.SetActive(true);
    }

}
