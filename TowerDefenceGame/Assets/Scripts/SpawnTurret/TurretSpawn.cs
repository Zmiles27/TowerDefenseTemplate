using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEngine.GraphicsBuffer;

public class TurretSpawn : MonoBehaviour
{
    Counters points;

    public GameObject AutoTurretPrefab;

    private bool canPlace = true;

    private void Start()
    {
        points = FindObjectOfType<Counters>();
        canPlace= true;
    }

    private void OnMouseDown()
    {
        if (canPlace == true)
        {
            points.BuyTurret();
            Instantiate(AutoTurretPrefab, this.transform.position, Quaternion.identity);
            canPlace = false;
        }
    }
}
