 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] [Range(1f, 10f)] float speed = 1f;
  //  [SerializeField] [Range(360f, 7200f)] float rotation = 360f;

    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector2.right *  speed * Time.deltaTime);
    // transform.Rotate(Vector3.forward, rotation * Time.deltaTime);

    }

}
