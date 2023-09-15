using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int score = 0;

    private void Start()
    {
        score = 0;
        text.text = "Score: " + score;
        Debug.Log("test");
    }

    public void EnemyKillScore()
    {
        score += 10;
        text.text = "Score: " + score;
        Debug.Log("score + 10");
    }
}
