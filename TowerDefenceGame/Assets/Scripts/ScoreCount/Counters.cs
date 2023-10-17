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
    public int prize;

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
        // Checks If player has hit amount of Enemies before going to next wave
        if (nextWave == nextWaveAmount)
        {
            nextWave= 0;
            spawnRate.ChangeDelay();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("You Cheater");
            points += 100;
            pointText.text = "Points: " + points;
        }
    }

    // score + 10 every time you kill an enemy
    public void EnemyKillScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    // points + 1 every time you kill an enemy
    public void EnemyKillPoints()
    {
        points += 1;
        nextWave += 1;
        pointText.text = "Points: " + points;
    }

    // Changes points when you buy Turret
    public void BuyTurret()
    {
        if(points >= prize)
        {
            points -= prize;
            pointText.text = "Points: " + points;
        }
    }
}
