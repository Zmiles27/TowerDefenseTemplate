using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counters : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pointText;
    

    public int score = 0;
    public int points = 0;

    private void Start()
    {
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
}
