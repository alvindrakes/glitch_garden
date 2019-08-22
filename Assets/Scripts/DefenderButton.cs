using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    Color originalColor;
    void Start()
    {
        LabelButtonsWithCost();
        originalColor = GetComponent<SpriteRenderer>().color;
    }

    private void LabelButtonsWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            Debug.Log(name + "has no cost text");
        } else
        {
            costText.text = defenderPrefab.getStarCost().ToString();

        }
    }

    void OnMouseDown()
    {
        ChangeDefenderColour();
    }

    void ChangeDefenderColour()
    {
        // defender button will turn white when clicked
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = originalColor;
        }
        GetComponent<SpriteRenderer>().color = Color.white;

        // reference defender spawner
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
