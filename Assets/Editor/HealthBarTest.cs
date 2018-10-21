using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class HealthBarTest {

    public class MonsterCurrentHealth
    {
        [Test]
        public void Current_Health_Half()
        {
            var monster = new Monster(.5f);

            Assert.AreEqual(.5f, monster.CurrentHealth);
        }
    }

}

public class Monster
{
    public float CurrentHealth { get; private set; }

    public Monster(float currentHealth)
    {
        CurrentHealth = currentHealth;
    }
}
