using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;


    // Start is called before the first frame update
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }

   
}
