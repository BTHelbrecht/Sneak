// Enemy Rotation
// Timer.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Public Class Timer MonoBehavoiour
public class Timer : MonoBehaviour {

// Public Variables
    // Set time for amount of time to count down
    public float startTime;
    // For gameobject game over canvas for winning (( JUST SURVIVE))
    public GameObject gameOverScreen;
    // For gameobjectr player
    public GameObject player;

// Private Variable
    // For UI TEXT on cavas world
    private Text uiText;


    // Use this for initialization
    void Start () { 
        // Gets text from canvas world component
        uiText = GetComponent<Text>();
	}
	


	// Update is called once per frame
	void Update () {
        // Actual countdown on realowrld seconds
        startTime -= Time.deltaTime;
        // Displays countdown in text on canvas world with rounded to int aspect
        uiText.text = "" + Mathf.Round(startTime);

        // If timer is less or equal to 0
        if(startTime <= 0)
        {
            // Display winner cavas, set timer to 0, and destroy player gameobject
            gameOverScreen.SetActive(true);
            startTime = 0;
            Destroy(player.gameObject);
        }
	}
}
