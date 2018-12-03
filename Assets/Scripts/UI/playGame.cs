// Enemy Rotation
// EnemyRatation.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Publlic Class playGame MonoBehaviour
public class playGame : MonoBehaviour
{
    // Public access to function
    public void PlayGame()
    {
        // Loads scene Main((ACTUAL GAME))... for button use
        SceneManager.LoadScene("Main");
    }
}
