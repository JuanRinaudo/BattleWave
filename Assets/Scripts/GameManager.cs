using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

	// Use this for initialization
	void Start () {
        instance = this;

        GameData.gameStartTimer = 3;
        GameData.gameRunning = false;

        GameData.roundOver = false;
        GameData.player1Won = false;
        GameData.player2Won = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(!GameData.gameRunning)
        {
            GameData.gameStartTimer -= Time.deltaTime;
            if(GameData.gameStartTimer <= 0)
            {
                GameData.gameRunning = true;
            }
        }
	}

    public void onPlayer1Death()
    {
        GameData.player2Won = true;
        GameData.player1Lives--;
        tryToResetStage();
    }

    public void onPlayer2Death()
    {
        GameData.player1Won = true;
        GameData.player2Lives--;
        tryToResetStage();
    }

    private void tryToResetStage()
    {
        if(GameData.player1Lives > 0 && GameData.player2Lives > 0)
        {
            GameData.gameRound++;
			GameData.player1Health = 3;
			GameData.player2Health = 3;
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        } else
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
