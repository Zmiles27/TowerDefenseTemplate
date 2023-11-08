using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class TurretSpawn : MonoBehaviour
{
    Counters count;

    public GameObject AutoTurretPrefab;

    public int prize;

    private void Start()
    {
        count = FindObjectOfType<Counters>();
    }

    private void OnMouseDown()
    {
        if (count.points >= prize)
        {
            count.pointSystem(-prize);
            Instantiate(AutoTurretPrefab, this.transform.position, Quaternion.identity);
        }
    }
}
