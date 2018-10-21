using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This is the driver class for the boss monster of our game
 * it takes a certain amount of clicks to defeat based on the static value
 * it contains instances of other scripts to allow functions to be called
 * and to effect the monster inside the game world.
*/

public class Movement_AI_Boss : MonoBehaviour {

    private static int CLICKS_TO_KILL = 9;
    private GameObject monster;
    public HealthBarScript_Boss hb;
    public float speed; //controls speed of falling
    public int numberOfClicks = 0;
    public TeleportScript_Boss Tele;

    void Start()
    {
        //Attaches game scripts to the object on instansiation.
        HealthBarScript_Boss hb = gameObject.GetComponent<HealthBarScript_Boss>();
        TeleportScript_Boss Tele = gameObject.GetComponent<TeleportScript_Boss>();
      
    }

    void OnMouseDown()
    {
        if (numberOfClicks > CLICKS_TO_KILL)  //Number of clicks to kill       
        {
            Destroy(gameObject); //Life reduced to 0
            numberOfClicks = 0;
        }
        else
        {
            ++numberOfClicks;
            hb.UpdateHealth(); // Updates healthbar graphic
            Tele.Teleport();  //Calls the teleport function when object is clicked.

        }
        //TODO add gold, exp and Loot script
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); // Gravity for falling object
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Edge")
        {
            Tele.Teleport();
        }
        
    }
}
