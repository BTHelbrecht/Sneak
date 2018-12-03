/*
EXIT GAME
exitGame.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class Public >> exitGame >> Mon0Behaviour
public class exitGame : MonoBehaviour {

	public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Succes.");
    }
}
