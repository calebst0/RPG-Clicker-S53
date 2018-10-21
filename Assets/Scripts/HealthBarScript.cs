using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    private static float DMG_APPLIER = .1f;
    public const float maxHealth = 1f;
    public float currentHealth = maxHealth;
    public Image healthbar;
    

    void Start()
    {

        currentHealth = maxHealth;
    }

    public void UpdateHealth()
    {
       currentHealth -= DMG_APPLIER; // Decrements the health bar graphic
        
      this.healthbar.fillAmount = currentHealth;
    }


}
