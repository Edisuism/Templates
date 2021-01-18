using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * To use the spawner, attach this script to a gameobject. Next add potential spawn locations as children.
 */

public class Spawner : MonoBehaviour
{
    private List<Transform> spawnLocations = new List<Transform>();
    [Header("Enemy Types")]
    [SerializeField] private GameObject[] enemyTypes;
    [Header("Start Spawn Time")]
    [SerializeField] private int startTime;
    [Header("Spawn Rate")]
    [SerializeField] private float spawnRate;

    void Start()
    {
        //Add all children transforms as potential spawn locations
        foreach(Transform child in transform)
        {
            spawnLocations.Add(child);
        }
        InvokeRepeating("SpawnEnemy", startTime, spawnRate);
    }


    void SpawnEnemy()
    {
        //Spawns a random enemy type at a random spawn location
        Instantiate(enemyTypes[Random.Range(0, enemyTypes.Length)], spawnLocations[Random.Range(0, spawnLocations.Count)].position, Quaternion.identity);
    }
}
