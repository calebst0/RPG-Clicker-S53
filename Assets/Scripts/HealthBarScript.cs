using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    public const float maxHealth = 1f;
    public float currentHealth = maxHealth;
    private Image healthbar;
    

    void Start()
    {
        this.healthbar = transform.Find("HealthCanvas").Find("HealthBG").Find("Health").GetComponent<Image>();
        
        currentHealth = maxHealth;
    }

    void Update()
    {
       

    }

    public void UpdateHealth()
    {
       this.currentHealth -= 0.25f; // Decrements the health bar graphic
        
      healthbar.fillAmount = currentHealth;
    }


}
