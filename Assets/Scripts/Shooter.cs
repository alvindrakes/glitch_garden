﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;
    Animator animator;
    AttackerSpawner myLaneSpawner;
    GameObject projectileParent;
    const string PROJECTILE_PARENT_NAME = "Projectiles";



    void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
        CreateProjectileParent();
    }

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    void Update()
    {
        if(IsAttackerInLane())
        {
            // fire when isAttacking is true
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);


        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        } else
        {
            return true;
        }
    }

    private void SetLaneSpawner()
    {
        // array of attackers 
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            // using y coordinate to determine whether the attacker and the defender are on the same lane 
            bool isCloseEnoughToShoot =
                Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon;

            if (isCloseEnoughToShoot)
            {
                myLaneSpawner = spawner;
            }

        }

     
    }

    public void Fire()
    {
        GameObject projectileCreated = Instantiate(projectile, gun.transform.position, gun.transform.rotation) as GameObject;
        projectileCreated.transform.parent = projectileParent.transform;
    }

}
