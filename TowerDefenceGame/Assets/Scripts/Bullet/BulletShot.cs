using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    ScoreCounter score;
    public float bulletSpeed;
    void Start()
    {
        score = FindObjectOfType<ScoreCounter>();
        Destroy(gameObject, 2);
    }

    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            score.EnemyKillScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
