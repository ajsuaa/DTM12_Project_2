using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Health : MonoBehaviour
{
    public TMP_Text healthText;
    public Image healthBar;

    float health, maxHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health + "%";
        //This makes sure that the health isn't greater than the maximum health
        if (health > maxHealth) health = maxHealth;

        HealthBarFiller();
    }

    void HealthBarFiller()
    {
        healthBar.fillAmount = health / maxHealth; 
    }

    public void Damage(float damagePoints)
    {
        if (health > 0)
            health -= damagePoints;
    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth)
            health += healingPoints;
    }
}

