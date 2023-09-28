using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Counters : MonoBehaviour
{
    EnemySpawnRate spawnRate;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pointText;

    private int nextWave;

    public int nextWaveAmount;
    public int score;
    public int points;

    private void Start()
    {
        spawnRate = FindObjectOfType<EnemySpawnRate>();

        nextWave = 0;
        score = 0;
        points = 0;
        scoreText.text = "Score: " + score;
    }

    public void Update()
    {
        if (nextWave == nextWaveAmount)
        {
            nextWave= 0;
            spawnRate.ChangeDelay();
        }
    }

    public void EnemyKillScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void EnemyKillPoints()
    {
        points += 1;
        nextWave += 1;
        pointText.text = "Points: " + points;
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + score;
    }
}
