using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    Weapon weapon;
    [SerializeField]
    UIManager UI;

    [SerializeField]
    int score;

    private void Awake()
    {
        weapon.OnDestroy += OnDestroyed;
    }

    private void Start()
    {
        UI.Score.SetText("0");
    }

    private void OnDestroyed()
    {
        score++;
        UI.Score.SetText(score.ToString());
    } 
}
