// Enemy Rotation
// Patrol.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Public CLass Patrol MonoBehaviour
public class Patrol : MonoBehaviour {

// Public variables
    // Speed for movement to new spot
    public float speed;
    // Spots for enemies to move too
    public Transform[] moveSpots;
    // randomly pick new spot for enemy to move too
    public int randomSpots;
    // starts a time for the enemy to wait before moving to new spot
    public float startWaitTime;

// Private Variables
    // a time for enemy to wait before moving to new spot
    private float waitTime;



	// Use this for initialization
	void Start () {
        // Wait time is start of new wait time
        waitTime = startWaitTime;
        // Genorates new random spot to move to
        randomSpots = Random.Range(0, moveSpots.Length);	
	}
	


	// Update is called once per frame
	void Update () {
        // move enemy to new spot
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);

        // Move enemy to new spot after 2sec.
        if(Vector2.Distance(transform.position, moveSpots[randomSpots].position) < 0.2f)
        {
            
            // Once enemy moves to new spot start new wait time and choose new random spot
            if(waitTime < 0)
            {
                // Random spot choosen again, and restart wait time
                randomSpots = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                // wait time is set to sec in actual time
                waitTime -= Time.deltaTime;
            }
        }
	}
}
