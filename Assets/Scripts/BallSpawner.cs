using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    [SerializeField] Transform loc1;
    [SerializeField] Transform loc2;
    [SerializeField] Transform loc3;
    [SerializeField] GameObject ball;    
    [SerializeField] float respawnTime = 1f;
    Transform randomPos;

    float timeLeft;

    void Start()
    {
        timeLeft = respawnTime; 
    }

    
    void Update()
    {
        if(timeLeft>0)
        {
            timeLeft -= Time.deltaTime;
        }   
        else
        {
            int randomPosNum = Random.Range(1,4);
            switch (randomPosNum)
            {
                case 1: randomPos = loc1;
                break;
                case 2: randomPos = loc2;
                break;
                case 3: randomPos = loc3;   
                break;
                
                default:
                break;
            }

            Instantiate(ball, randomPos.transform.position, Quaternion.identity);

            timeLeft = respawnTime;
        }
    }

}
