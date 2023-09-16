using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counters : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pointText;
    

    public int score;
    public int points;

    private void Start()
    {
        score = 0;
        points = 0;
        scoreText.text = "Score: " + score;
    }

    public void EnemyKillScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void EnemyKillPoints()
    {
        points += 1;
        pointText.text = "Points: " + points;
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + score;
    }
}
