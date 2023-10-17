using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class TurretSpawn : MonoBehaviour
{
    Counters points;

    public GameObject AutoTurretPrefab;

    private void Start()
    {
        points = FindObjectOfType<Counters>();
    }

    private void OnMouseDown()
    {
        if (points.points >= points.prize)
        {
            points.BuyTurret();
            Instantiate(AutoTurretPrefab, this.transform.position, Quaternion.identity);
            points.points -= points.prize;
        }
    }
}
