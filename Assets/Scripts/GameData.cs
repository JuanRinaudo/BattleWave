﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

    public static GameObject player1;
    public static GameObject player2;

    public static int gameRound = 1;
    public static int player1Lives = 4;
    public static int player2Lives = 4;
    public static int playerLives = 4;
    public static int player1RoundWins = 0;
    public static int player2RoundWins = 0;

    public static int player1Health = 3;
	public static int player2Health = 3;

	public static float time;

    public static bool roundOver;
    public static bool player1Won;
    public static bool player2Won;

}
