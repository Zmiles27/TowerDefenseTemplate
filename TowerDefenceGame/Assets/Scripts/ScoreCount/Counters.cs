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

    public int waveState;
    public int score;
    public int points;
    public int prize;

    private void Start()
    {
        spawnRate = FindObjectOfType<EnemySpawnRate>();

        nextWave= 5;
        waveState = 0;
        score = 0;
        points = 0;
        scoreText.text = "Score: " + score;
    }

    public void scoreSystem(int scoreCount)
    {
        score += scoreCount;
        scoreText.text = "Score: " + score;
    }

    public void pointSystem(int pointCount)
    {
        points += pointCount;
        pointText.text = "Points: " + points;
    }

    public void waveSystem(int waveCount)
    {
        waveState += waveCount;
        pointText.text = "Points: " + points;

        if (waveState == nextWave)
        {
            waveState = 0;
            spawnRate.ChangeDelay();
        }
    }
}
