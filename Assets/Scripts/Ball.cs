using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    [SerializeField] Rigidbody body;
    [SerializeField] float force = 10f;
    [SerializeField] float maxSpeed = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(body.velocity.z > -maxSpeed)
        {
            body.AddForce(Vector3.back * force); 
        }
          
    }
}
