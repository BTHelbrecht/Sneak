// Enemy Rotation
// EnemyRatation.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Public Class EnemyRotation MonoBehaviour
public class EnemyRotation : MonoBehaviour {

// Public Variables
    // For enemy rotation speed
    public float rotationSpeed;
    // Enemy line of sight distance
    public float distance;
    // Line renderer
    public LineRenderer lineOfSight;
    // Line color hitting objects
    public Gradient redColor;
    // Line color not hitting objects
    public Gradient greenColor;
    // Used to call game over canvas
    public GameObject gameOverScreen;



	// Use this for initialization
	void Start () {
        // ignore enemies own collider
        Physics2D.queriesStartInColliders = false;
	}
	


	// Update is called once per frame
	void Update () {

        // rotate enemy based of time not frame on vector3 (Z) axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
         // Raycast to rotate line with enemy
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);

        // If collider is not hit by raycast
        if (hitInfo.collider != null)
        {
            // display line of sight as red when hitting obstacles
            lineOfSight.SetPosition(1, hitInfo.point);
            lineOfSight.colorGradient = redColor;
            
            // If raycast hit the player
            if (hitInfo.collider.CompareTag("Player"))
            {
                // displays canvas that is for loser AND destroys player gameobject
                gameOverScreen.SetActive(true);
                Destroy(hitInfo.collider.gameObject);

            }
        
        }
        else
        {
            // If enemy is not hitting anything with raycast display green line as line of sight
            lineOfSight.SetPosition(1, transform.position + transform.right * distance);
            lineOfSight.colorGradient = greenColor;
        }

        // sets position of start for line of sight at the postion of enemy
        lineOfSight.SetPosition(0, transform.position);
    }
}
