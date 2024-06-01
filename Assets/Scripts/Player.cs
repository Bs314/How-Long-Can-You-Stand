using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] Transform rightLimit;
    [SerializeField] Transform leftLimit;
    [SerializeField] GameObject button;
    [SerializeField] GameObject leftButton;
    [SerializeField] GameObject rightButton;

    float horizontalMove;
    bool playerAlive = true;
    bool buttonPressed = false;
    float moveInfoFromButton;
    void Start()
    {
        Player abc = GetComponent<Player>();
    }

    
    void Update()
    {

        if(playerAlive)
        {
            Move();
        }

        
        
    }

    void Move()
    {
        float limLeft = leftLimit.position.x;
        float limRight = rightLimit.position.x;
        float playerPosition = transform.position.x;
        if(buttonPressed)
        {
            horizontalMove = moveInfoFromButton;
        }
        else{
            horizontalMove = Input.GetAxis("Horizontal");
        }
           
        if((playerPosition > limLeft && horizontalMove < 0) || (playerPosition < limRight && horizontalMove > 0))
        {
            transform.Translate(new Vector3(horizontalMove * moveSpeed * Time.deltaTime,0,0));
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Ball")
        {
            Debug.Log("Ball");
            GetComponent<Rigidbody>().freezeRotation = false;
            playerAlive = false;
            rightButton.SetActive(false);
            leftButton.SetActive(false);
            button.SetActive(true);
        }
    }


    

    public bool getPlayerStatus()
    {
        
        return playerAlive;
    }

    public void GoRight(){
        buttonPressed = true;
        moveInfoFromButton = 1;
    }

    public void GoLeft(){
        buttonPressed = true;
        moveInfoFromButton = -1;
    }

    public void ButtonFree()
    {
        moveInfoFromButton = 0;
        buttonPressed = false;
    }


}
