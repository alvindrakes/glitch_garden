using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range (0f, 5f)]
    float currentSpeed = 1f;
    GameObject currentTarget;

    void Awake()
    {
        FindObjectOfType<LevelController>().AttackerSpawned();

    }

    void OnDestroy()
    {
        FindObjectOfType<LevelController>().AttackerKilled();

    }


    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget) { return;  }

        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.dealDamage(damage);
        } 
    }

    // if the defender is dead, attacker continue walking 
    private void UpdateAnimationState()
    {
        if(!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }
}
