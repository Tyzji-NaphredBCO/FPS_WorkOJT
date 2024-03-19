using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using System;

public class RealScoreSystem : MonoBehaviour
{
    public event Action openVictory;

    [SerializeField]
    TextMeshProUGUI scoreText;
    [SerializeField]
    GameObject Victory;

    public int winScoreCondition;
    private int score;
    private string pointString;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointString = scoreText.text;
        score = int.Parse(pointString.Replace("Score: ", ""));
        if (score >= winScoreCondition)
        {
            Victory.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
 }
