using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    Color originalColor;
    void Start()
    {
        originalColor = GetComponent<SpriteRenderer>().color;
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
