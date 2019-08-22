using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollider : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<HealthDisplay>().minusHealth();
        Destroy(otherCollider.gameObject);
    }
}
