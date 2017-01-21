using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour {

	public void loadMenu()
    {
        GameData.player1Lives = GameData.playerLives;
        GameData.player2Lives = GameData.playerLives;
		GameData.player2Health = 3;
		GameData.player1Health = 3;

        GameData.gameRound = 0;
        SceneManager.LoadScene ("MainState");
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
