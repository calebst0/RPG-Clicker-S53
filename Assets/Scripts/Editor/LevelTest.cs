using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class LevelTest
{

    [Test]
    public void LevelUp_Test()
    {

        var gameObject = new GameObject();
        gameObject.AddComponent<LevelingScript>();

        int xpGain = 50;
        int expectedLevel = 2;
        gameObject.GetComponent<LevelingScript>().AddExperience(xpGain);
        int level = gameObject.GetComponent<LevelingScript>().currentLevel;

        Assert.AreEqual(expectedLevel, level);
    }
}
