using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    [SerializeField] Rigidbody body;
    [SerializeField] float force = 10f;
    [SerializeField] float baseSpeed = 10f;
    [SerializeField] float randomSpeed = 2f;
    [SerializeField] float falsoForce = 5f;

    void Start()
    {
        BallDestroyer score = FindObjectOfType<BallDestroyer>();
        int level = score.getLevel();
        float falso = Random.Range(-falsoForce,falsoForce);
        body.AddForce(new Vector3(falso,0,0) * force);   
        baseSpeed = baseSpeed * (1.2f * level);
        baseSpeed = baseSpeed + Random.Range(-randomSpeed,randomSpeed);   
    }

    
    void Update()
    {
        if(body.velocity.z > -baseSpeed)
        {
            body.AddForce(Vector3.back * force); 
        }
          
    }
}
