using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    public const float maxHealth = 1f;
    public float currentHealth = maxHealth;
    public Image healthbar;

    void Start()
    {

        currentHealth = maxHealth;

    }

    void Update()
    {
       

    }

    public void UpdateHealth()
    {
       currentHealth -= 0.25f; // Decrements the health bar graphic
        
       this.healthbar.fillAmount = currentHealth;
    }


}
