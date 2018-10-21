using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class LevelTest {
    
    [Test]
    public void LevelUp_Test() {

        var gameObject = new GameObject();
        gameObject.AddComponent<LevelingScript>();

        int xpGain = 50;
        int expectedLevel = 2;
        gameObject.GetComponent<LevelingScript>().AddExperience(xpGain);
        int level = gameObject.GetComponent<LevelingScript>().currentLevel;

        Assert.AreEqual(expectedLevel, level);

    }
    

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    /*
    [UnityTest]
    public IEnumerator LevelTestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame

        var LevelingScript = new levelTest();

        levelTest.addExperience(50);

        Assert.That(levelTest.currentLevel, Is.EqualTo(2));


        yield return null;
    }
    */
}
