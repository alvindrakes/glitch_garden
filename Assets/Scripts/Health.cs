using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100f;
    // Start is called before the first frame update
   public void dealDamage(float damage) {
       health -= damage; 
       if (health <= 0)
       {
           Destroy(gameObject);
       }
   }

}
