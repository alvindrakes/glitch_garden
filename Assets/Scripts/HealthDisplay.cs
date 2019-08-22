using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    [SerializeField] float baseHealth = 3;
    [SerializeField] int damage;
    float health;
    Text healthText;


    void Start()
    {
        health = baseHealth - PlayerPrefsController.GetDifficulty();
        healthText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        healthText.text = "Lives: " + health.ToString();
    }

    public void minusHealth()
    {
        health -= damage;
        UpdateText();

        if(health <= 0)
        {

            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
