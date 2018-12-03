// Enemy Rotation
// Controls.cs
// JERARD CARNEY
// 12.2.18

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Public Class Controls MonoBehaviour
public class Controls : MonoBehaviour {

// Public Variables
    // Speed of Player
    public float speed;
    // Rigid body 2D of player gameobject
    public Rigidbody2D rb;
    // Velocity of movement
    private Vector2 moveVelocity;



    // Use this for initialization
    void Start()
    {
        // Gets player gameobject rigidbody 2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Gets player inputs and moves the player velocity * speed in directions input
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        // Moves the actual rigidbody 2D... Player
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
