using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This is the functionality of the health bar for our boss monster
 * it contains an image object that decreases when the attached object
 * detects a click on itself. It then decreases based on the damage it dealt.
 */

public class HealthBarScript_Boss : MonoBehaviour {

    private static float DMG_APPLIER = .1f;
    public const float maxHealth = 1f;
    public float currentHealth = maxHealth;
    public Image healthbar; //The health image instance that decreases on click.


    void Start()
    {
        currentHealth = maxHealth;
    }

    public void UpdateHealth()
    {
        currentHealth -= DMG_APPLIER; // Decrements the health bar graphic

        this.healthbar.fillAmount = currentHealth; //Updates the new value of the healthbar.
    }
}
