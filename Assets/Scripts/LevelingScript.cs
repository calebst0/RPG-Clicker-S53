using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingScript : MonoBehaviour
{

    public int currentXp;
    public int currentLevel;
<<<<<<< HEAD
    public int[] xpPerLevel = new int[50];
=======
    public int[] xpPerLevel;
>>>>>>> Caleb

	// Update is called once per frame
	void Update ()
    {
<<<<<<< HEAD
=======

>>>>>>> Caleb
        if (currentXp >= xpPerLevel[currentLevel])
        {
            currentLevel++;
        }
    }

    public void addExperience(int xpGained)
    {
        currentXp += xpGained;
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> Caleb
