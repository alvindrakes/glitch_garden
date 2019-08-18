using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        starText.text = stars.ToString(); 
    }

    public bool HaveEnoughStars(int starCost)
    {
        return stars >= starCost;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateText();
    }

    public void SpendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateText();
        }
      
    }
}
