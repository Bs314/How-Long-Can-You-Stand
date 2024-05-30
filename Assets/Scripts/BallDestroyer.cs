using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
    }
}
