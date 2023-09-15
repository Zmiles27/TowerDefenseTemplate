using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyMovent : MonoBehaviour
{
    public TowerHealth towerHealth;

    public List<GameObject> downRoute1;
    public List<GameObject> downRoute2;
    public List<GameObject> upRoute1;
    public List<GameObject> upRoute2;

    int index = 0;

    [SerializeField] int routeIndex = 0;


    public List<List<GameObject>> routes;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        towerHealth = FindObjectOfType<TowerHealth>();

        // List of Lists
        routes = new List<List<GameObject>>();
        routes.Add(downRoute1);
        routes.Add(downRoute2);
        routes.Add(upRoute1);
        routes.Add(upRoute2);

        // Randomizes Route From List
        routeIndex = Random.Range(0, routes.Count);

        // Chooses spawn Location
        if (routeIndex <= 1)
        {
            transform.position = new Vector3(-9, -3, -3);
        }

        else if (routeIndex >= 2)
        {
            transform.position = new Vector3(-9, 2, -3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Checks For all Waypoints
        Vector3 destination = routes[routeIndex][index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        float distance = Vector3.Distance(transform.position, destination);

        // Goes To next Waypoint when at Waypoint
        if (distance <= 0.05)
        {
            if (index < routes[routeIndex].Count - 1)
            {
                index++;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Tower")
        {
            towerHealth.TakeDemage(10);
        }
    }
}
