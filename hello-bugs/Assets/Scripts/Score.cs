using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int ballValue;


    private int score;

    // Use this for initialization
    void Start()
    {
        score = 0;
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        score += ballValue;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score:\n" + score.ToString();
    }

}
