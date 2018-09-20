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
            spawnObjects();
        }
            
    }

    void spawnObjects()
    {
        int spawnPointIndex = Random.Range(0, spawnLocations.Length);
        //int monsterIndex = Random.Range(0, number of monsters in game); TODO

        Instantiate(clonedPrefab[0], spawnLocations[spawnPointIndex].position, spawnLocations[spawnPointIndex].rotation);


        //Alternative cloning of all spawn locations
       /* clonedPrefab[0] = Instantiate(spawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        clonedPrefab[1] = Instantiate(spawnPrefab[1], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject; 
        clonedPrefab[2] = Instantiate(spawnPrefab[2], spawnLocations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;*/
        
    }

}
