using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

	// Use this for initialization
	void Start () {
        instance = this;
        
        GameData.roundOver = false;
        GameData.player1Won = false;
        GameData.player2Won = false;
    }
	
	// Update is called once per frame
	void Update () {
		
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
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        } else
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
