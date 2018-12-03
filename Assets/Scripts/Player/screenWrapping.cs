/*
SCREENWRAPPING
screenWrapping.cs
JERARD CARNEY
NOVEMBER.24.2018
*/

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class screenWrapping >> MonoBehavior
public class screenWrapping : MonoBehaviour {

// Public Variables
    // Access to ships rigidy body
    public Rigidbody2D body;
    // Top limit screen
    public float screenTop;
    // Bottom limit screen
    public float screenBottom;
    // Left limit screen
    public float screenLeft;
    // Right limit screen
    public float screenRight;



    // Use this for initialization
    void Start ()
    {
		
	}
	



	// Update is called once per frame
	void Update ()
    {
        // Screen wrapping affect for ship to stay in view
        // Set to ships position and applied if ship is off screen
        Vector2 relocate = transform.position;

        // If ship loaction is past screen top
        if (transform.position.y > screenTop)
        {
            // Relocates ship to screen bottom
            relocate.y = screenBottom;
        }

        // If ship loaction is past screen bottom
        if (transform.position.y < screenBottom)
        {
            // Relocates ship to screen top
            relocate.y = screenTop;
        }

        // If ship loaction is past screen left
        if (transform.position.x < screenLeft)
        {
            // Relocates ship to screen right
            relocate.x = screenRight;
        }

        // If ship loaction is past screen right
        if (transform.position.x > screenRight)
        {
            // Relocates ship to screen left
            relocate.x = screenLeft;
        }


        // Sets ship posistion every frame
        transform.position = relocate;

    }
}
