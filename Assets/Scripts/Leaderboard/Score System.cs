using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int point;
    public TextMeshProUGUI scoreText;
    private int score = 0; // Initialize score to 0

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(gameObject);
            print("Hit " + collision.gameObject.name + " !");
            string pointString = scoreText.text;
            int score = int.Parse(pointString.Replace("Score: ", ""));
            score+= point;
            scoreText.text = "Score: " + score.ToString();
             


        }
    }
}
