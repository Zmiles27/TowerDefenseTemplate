using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnDelay;
    private bool canSpawn;

    public List<GameObject> downRoute1;
    public List<GameObject> downRoute2;
    public List<GameObject> upRoute1;
    public List<GameObject> upRoute2;

    public List<List<GameObject>> routes;
    public float speed = 2;
    int index = 0;

    [SerializeField] int routeIndex = 0;


    private void Start()
    {
        Instantiate(enemyPrefab);

        // List of Lists
        routes = new List<List<GameObject>>();
        routes.Add(downRoute1);
        routes.Add(downRoute2);
        routes.Add(upRoute1);
        routes.Add(upRoute2);

        // Randomizes Route From List
        routeIndex = Random.Range(0, routes.Count);
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");


        // Chooses spawn Location
        if (routeIndex <= 1)
        {
            enemy.transform.position = new Vector3(-9,-4,-3);
        }

        else if (routeIndex >= 2)
        {
            enemy.transform.position = new Vector3(-9, 4, -3);
        }
    }

    private void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        
        // Checks For all Waypoints
        Vector3 destination = routes[routeIndex][index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(enemy.transform.position, destination, speed * Time.deltaTime);
        enemy.transform.position = newPos;
        float distance = Vector3.Distance(enemy.transform.position, destination);
   
        // Goes To next Waypoint when at Waypoint
        if(distance <= 0.05)
        {
            if(index < routes[routeIndex].Count-1)
            {
                index++;
            }
        }
    }
}
