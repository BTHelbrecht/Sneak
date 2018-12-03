// Enemy Rotation
// getOptions.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Public CLass getOptions MonoBehaviour
public class getOptions : MonoBehaviour
{

    // Public access to function
    public void GetOptions()
    {
        // Loads scene Options... for buttton use
        SceneManager.LoadScene("Options");
    }
}