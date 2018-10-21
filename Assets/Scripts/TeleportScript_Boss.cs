using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript_Boss : MonoBehaviour {

    /*Teleport class for our boss functionality, on click it will
     * teleport to a random location in the scene based on RNG call.
    */

    public Transform[] TeleportLocations; // Holds the Destination tranforms locations.
    public GameObject boss;

    public void Teleport()
    {
       int teleportIndex = Random.Range(0, TeleportLocations.Length);

       boss.transform.position = TeleportLocations[teleportIndex].transform.position; //Teleports to a random transfrom based on our RNG.
    }

}
