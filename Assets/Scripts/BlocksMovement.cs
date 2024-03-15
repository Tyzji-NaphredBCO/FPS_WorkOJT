using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksMovement : MonoBehaviour
{
    public float speed = 2f; // Adjust the speed of movement
    public float distance = 5f; // Adjust the distance the block moves
    private bool moveRight = true; // Determines if the block should move right initially

    private Vector3 startPosition;
    private float movementTimer;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Increment the timer
        movementTimer += Time.deltaTime * speed;

        // Check if the timer exceeds the distance
        if (movementTimer >= distance)
        {
            // Toggle direction
            moveRight = !moveRight;
            movementTimer = 0f;
        }

        // Calculate movement direction
        Vector3 movementDirection = moveRight ? Vector3.right : Vector3.left;

        // Move the block
        transform.Translate(movementDirection * Time.deltaTime * speed);
    }
}