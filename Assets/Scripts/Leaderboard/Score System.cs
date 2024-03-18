using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int point;
    private TextMeshProUGUI scoreText;
    private int score = -1; // Initialize score to 0
    public int winScoreCondition;

    private GameObject Victory;

    private void Start()
    {
        scoreText = GameObject.Find("scoreText").GetComponent<TextMeshProUGUI>();
        Victory = GameObject.Find("Victory");

    }

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
        if (score >= winScoreCondition) {
            Debug.Log(Victory);
            Victory.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }else
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
