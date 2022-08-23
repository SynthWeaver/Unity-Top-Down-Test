using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Speed of player
    public float moveSpeed = 5f;
    
    // Physics object of Unity
    public Rigidbody2D rb;

    // Animator object of Unity
    public Animator animator;

    // Something to store movement data
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Input 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // FixedUpdate is called every fixed framerate frame 
    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime );
    }
}
