using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {

        // Check if the collision is with any of the target tags
        if (other.gameObject.CompareTag("Red") || other.gameObject.CompareTag("Blue") ||
            other.gameObject.CompareTag("Green") || other.gameObject.CompareTag("Yellow") ||
            other.gameObject.CompareTag("Violet"))
        {
            scoreText.text = score.ToString();
            // Print the object hit
            print("Hit " + other.gameObject.name + " !");
            
            // Increment the score
            score += 1;
            
            // Log the score increase
            Debug.Log("+1 point! New score: " + score);
        }
    }
}
