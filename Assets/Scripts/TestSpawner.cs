using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSpawner : MonoBehaviour {

    public Transform[] spawnLocations;
    public GameObject[] spawnPrefab;
    public GameObject[] clonedPrefab;
    public float secondsToSpawn = 2.0f;

    private void Update()
    {
        secondsToSpawn -= Time.deltaTime;

        if (secondsToSpawn <= 0.0f)
        {
            secondsToSpawn = 1.0f;
            SpawnObjects();
        }
            
    }

    void SpawnObjects()
    {
        int spawnPointIndex = Random.Range(0, spawnLocations.Length);
        int monsterIndex = Random.Range(0, 3);

        Instantiate(clonedPrefab[monsterIndex], spawnLocations[spawnPointIndex].position, spawnLocations[spawnPointIndex].rotation);
        
    }

}
