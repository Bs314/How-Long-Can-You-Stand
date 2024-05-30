using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallSpawner : MonoBehaviour
{
    
    [SerializeField] Transform loc1;
    [SerializeField] Transform loc2;
    [SerializeField] Transform loc3;
    [SerializeField] GameObject ball;    
    [SerializeField] BallDestroyer score;
    [SerializeField] float respawnTime = 1f;
    [SerializeField] Player player;
    bool playerAlive = true;
    Transform randomPos;
    float timeLeft;
    int level = 1;
    int oldLevel;

    void Start()
    {
        oldLevel = level;
        level = 1;
        timeLeft = respawnTime; 
    }

    
    void Update()
    {
        playerAlive = player.getPlayerStatus();
        level = score.getLevel();
        if(level != oldLevel)
        {
            oldLevel = level;
            if(respawnTime>0.3)
            {
                respawnTime -= 0.15f;
            }
            
        }
        if(playerAlive)
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

}
