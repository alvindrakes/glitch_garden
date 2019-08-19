using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollider : MonoBehaviour
{
   void OnTriggerEnter2D()
    {
        FindObjectOfType<HealthDisplay>().minusHealth();
    }
}
