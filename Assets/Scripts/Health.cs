using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    Color originalColour;
    [SerializeField] float flashTime;

    private void Start() {
        originalColour = GetComponent<SpriteRenderer>().color;
    }

    void FlashRed()
     {
        GetComponent<SpriteRenderer>().color = Color.red;
         Invoke("ResetColor", flashTime);
    }

    void ResetColor()
    {
       GetComponent<SpriteRenderer>().color = originalColour;
    }

    // Start is called before the first frame update
   public void dealDamage(float damage) {
        FlashRed();
       health -= damage; 
      
      
        if (health <= 0)
       {
           TriggerDeathVFX();
           Destroy(gameObject);
       }
      
   }

     private void TriggerDeathVFX()
     {
         if (!deathVFX)
         {
             return;
         }
         GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
     }

}
