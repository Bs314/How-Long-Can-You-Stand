using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPusher : MonoBehaviour
{
    [SerializeField] float pushForce = 5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

   private void OnTriggerStay(Collider other) {
        if(other.tag != "Player")
        {
            float pusherPosition = transform.position.x;
            float ballPosition = other.transform.position.x;
            Rigidbody ballBody = other.GetComponent<Rigidbody>();

            if(pusherPosition<ballPosition)
            {
                ballBody.AddForce(Vector3.right * pushForce);
            }
            if(pusherPosition>ballPosition)
            {
                ballBody.AddForce(Vector3.right * -pushForce);
            }
        }
        
   }
}
