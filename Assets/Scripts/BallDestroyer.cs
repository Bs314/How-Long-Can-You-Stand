using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
  
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Player player;
    [SerializeField] int scorePoint = 50;
    int score = 0;
    int level = 1;
    int imagineScore;
    void Start()
    {
        scoreText.text = score.ToString(); 
        Invoke("",20);  
    }

   
    void Update()
    {   
        if(imagineScore==500)
        {
            imagineScore = 0;
            level++;
        }
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        if(other.tag == "Ball")
        {
            if(player.getPlayerStatus())
            {
                score += scorePoint;
                imagineScore+=scorePoint;
                scoreText.text = score.ToString();    
            }
        }
        
    }

    public int getScore()
    {
        return score;
    }
    public int getLevel()
    {
        return level;
    }
}
