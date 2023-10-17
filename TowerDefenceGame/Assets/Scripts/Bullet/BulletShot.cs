using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    Counters score;
    // TurretSpawn turretSpawn; 
    public float bulletSpeed;
    void Start()
    {
        score = FindObjectOfType<Counters>();
        // turretSpawn = FindObjectOfType<TurretSpawn>();
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
            score.EnemyKillPoints();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
