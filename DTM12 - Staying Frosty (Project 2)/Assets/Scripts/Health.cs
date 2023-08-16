//THIS SCRIPT IS FROM A SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Health : MonoBehaviour
{
    //This displays the Health Text (The text above the health bar)
    public TMP_Text healthText;
    //This displays the Health Bar
    public Image healthBar;

    //Health
    float currentHealth= 0f;

    //Shows the maximum amount of health
    float health, maxHealth = 100;
    //This makes the health UI smoother
    float lerpSpeed;
    


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
        ColorChanger();

        if (health <= 0)
        {
            currentHealth = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

    }

    void HealthBarFiller()
    {
        //This allows the animaton for the health bar decreasing and increasing a lot more smoother
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health / maxHealth, lerpSpeed);
    }

    void ColorChanger()
    {
        Color healthColor = Color.Lerp(Color.blue, Color.green, (health / maxHealth));
        healthBar.color = healthColor;
    }



    public void Damage(float damagePoints)
    {
        //This lowers the health
        if (health > 0) 
            health -= damagePoints;
    }

    public void Heal(float healingPoints)
    {
        //This increases the health
        if (health < maxHealth)
            health += healingPoints;
    }
}



