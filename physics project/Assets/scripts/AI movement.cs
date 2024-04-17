using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AImovement : MonoBehaviour
{
    public Transform target; // Reference to the target object (the pug)
    public float speed = 1f;


    void Update()
    {
        if (target != null)
        {
            
            Vector3 direction = target.position - transform.position;


            direction.y = 0f;
            direction.z = 0f;

            
            direction.Normalize();

          
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}

