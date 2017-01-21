using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Text player1WinText;
    public Text player2WinText;

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
        GameData.player2RoundWins++;
        tryToResetStage();
    }

    public void onPlayer2Death()
    {
        GameData.player1Won = true;
        GameData.player2Lives--;
        GameData.player1RoundWins++;
        tryToResetStage();
    }

    private void tryToResetStage()
    {
        Debug.Log(GameData.player1Lives);
        Debug.Log(GameData.player2Lives);

        if (GameData.player1Lives > 0 && GameData.player2Lives > 0)
        {
            GameData.gameRound++;
			GameData.player1Health = 3;
			GameData.player2Health = 3;
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        } else
        {
            if (GameData.player1Lives == 0) ;
            //gano el player2
            else if (GameData.player2Lives == 0) ;
            // gano el player 1
            else 
                //error programaron con el culo


                GameData.player1RoundWins = 0;
            GameData.player2RoundWins = 0;
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
