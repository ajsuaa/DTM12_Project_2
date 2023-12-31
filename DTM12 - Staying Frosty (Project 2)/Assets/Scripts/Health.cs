//THIS SCRIPT IS FROM A TUTORIAL

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
    public float healthDecreaseRate = 20f;
    // Set the countdown duration
    public float countdownDuration = 60f; 
    //Health
    float currentHealth = 0f;
    //Shows the maximum amount of health
    float health, maxHealth = 100;
    //This makes the health UI smoother
    float lerpSpeed;
    float currentTime;
    float startingTime; 

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
       //Intialize currentTime to countdownDuration
        currentTime = countdownDuration; 
    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= Time.deltaTime;
        health = (currentTime / countdownDuration) * maxHealth;
        healthText.text = "Temperature: " + Mathf.RoundToInt(health) + "%";
        //This makes sure that the health isn't greater than the maximum health
        if (health > maxHealth) health = maxHealth;

        HealthBarFiller();
        ColorChanger();

        //If there is no more health, the player is transferred to the "Game Over" scene
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
        Color healthColor = Color.Lerp(Color.blue, Color.red, (health / maxHealth));
        healthBar.color = healthColor;
    }

    public void Damage(float damagePoints)
    {
        //This lowers the health
        if (health > 0) 
            health -= damagePoints;

        currentTime -= 1 * Time.deltaTime;
    }

    public void Heal(float healingPoints)
    {
        //This increases the health
        if (health < maxHealth)
            health += healingPoints;
    }
}



