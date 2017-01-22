using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetMatch : MonoBehaviour {

    public void ResetGame()
    {
        GameData.player1Lives = 4;
        GameData.player2Lives = 4;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}
