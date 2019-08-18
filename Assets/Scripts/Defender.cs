using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 50;
    [SerializeField] float timeForStar = 5;
   
    public void AddStar(int amount)
    {
        StartCoroutine(waitForStar());
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

    IEnumerator waitForStar()
    {
        yield return new WaitForSeconds(timeForStar);
    }

    public int getStarCost()
    {
        return starCost;
    }

}
