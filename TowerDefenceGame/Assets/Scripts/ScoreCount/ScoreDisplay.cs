using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private Counters counters;

    private void Start()
    {
        counters = FindObjectOfType<Counters>();
        counters.DisplayScore();
    }
}