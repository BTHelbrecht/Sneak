// Enemy Rotation
// mainMenu.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Public Class mainMenu MonBehaviour
public class mainMenu : MonoBehaviour {

    // Public access to function
	public void GetMenu()
    {
        // Load scene Menu... for button use
        SceneManager.LoadScene("Menu");
    }
}
