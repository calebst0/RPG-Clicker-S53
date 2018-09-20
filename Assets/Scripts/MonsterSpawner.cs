using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2.0f;
    float nextSpawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        nextSpawn = Time.time + spawnRate;
        randX = Random.Range(-960f, -550f);
        whereToSpawn = new Vector2(randX, transform.position.y);
        Instantiate(enemy, whereToSpawn, Quaternion.identity);
		
	}
}
