using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement_AI : MonoBehaviour {

    private static int CLICKS_TO_KILL = 9;
    private GameObject monster;
    public HealthBarScript hb;
    public float speed;
    public int numberOfClicks = 0;
    public TeleportScript_Boss Tele;

    void Start()
    {
        HealthBarScript hb = gameObject.GetComponent<HealthBarScript>();
        TeleportScript_Boss Tele = gameObject.GetComponent<TeleportScript_Boss>();
    }

    void OnMouseDown()
    {
        if (numberOfClicks > CLICKS_TO_KILL)  //Number of clicks to kill       
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Edge")
        {
            Tele.Teleport();
        }
    }

}
