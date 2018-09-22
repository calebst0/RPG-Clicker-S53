using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingScript : MonoBehaviour
{

    public int currentXp;
    public int currentLevel;
    public int[] xpPerLevel;

	// Update is called once per frame
	void Update ()
    {

        if (currentXp >= xpPerLevel[currentLevel])
        {
            currentLevel++;
        }
    }

    public void addExperience(int xpGained)
    {
        currentXp += xpGained;
    }
}
