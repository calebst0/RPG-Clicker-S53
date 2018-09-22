using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private Stat health;
    [SerializeField]
    private Stat energy;

    private void Awake()
    {
        health.Initialize();
        energy.Initialize();
    }

    // Use this for initialization
    void Start ()
    {

		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal -= 10;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            health.CurrentVal += 10;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            energy.CurrentVal -= 10;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            energy.CurrentVal += 10;
        }
    }
}
