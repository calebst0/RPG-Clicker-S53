﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement_AI : MonoBehaviour {

    private GameObject monster;
    public HealthBarScript hb;
    public float speed;
    public int numberOfClicks = 0;
    
    void Start()
    {
 
        HealthBarScript hb = gameObject.GetComponent<HealthBarScript>();
        
    }

    void OnMouseDown()
    {
        if (numberOfClicks > 2)  //Number of clicks to kill       
        {
            Destroy(gameObject);
            numberOfClicks = 0;
        }
        else
        {
            ++numberOfClicks;
            hb.UpdateHealth(); // Updates healthbar graphic

        }
        //TODO gold, exp and Loot
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); // Gravity for falling object
    }
	
}
