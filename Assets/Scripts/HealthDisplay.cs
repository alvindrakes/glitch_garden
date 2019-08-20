using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    [SerializeField] int health;
    [SerializeField] int damage;
    Text healthText;


    void Start()
    {
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
            FindObjectOfType<LevelLoad>().YouLose();
        }
    }
}
