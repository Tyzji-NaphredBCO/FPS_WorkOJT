using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class Timer : MonoBehaviour
{
    public GameObject gamePlayUI;
    public TextMeshProUGUI timerText;
    public GameObject gameOverUI;
    public float totalTime = 60f; // Total time for the countdown
    private float timeRemaining; // Time remaining for the countdown

    void Start()
    {
        timeRemaining = totalTime;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            Debug.Log("Time's up!");
            gamePlayUI.SetActive(false);
            gameOverUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            timeRemaining = 0;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
