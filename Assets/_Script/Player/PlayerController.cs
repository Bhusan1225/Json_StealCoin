using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerModel playerModel;
    private PlayerView playerView;



    public PlayerController(PlayerModel model, PlayerView view)
    {
        this.playerModel = model;
        this.playerView = view;
        Start();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        PlayerMovement();   
    }

    private void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movementInput = new Vector3(horizontal, 0, vertical).normalized;
        var movementAmount = Mathf.Clamp01( Mathf.Abs(horizontal) + Mathf.Abs(vertical));

       var moveDirection = playerModel.mainCamera.flatRotation * movementInput; // here I need to multiply the flat camera rotation

        if (movementAmount > 0)
        {
            playerModel.player.transform.position += moveDirection * playerModel.speed * Time.deltaTime;
            playerModel.requiredRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        }


        playerModel.player.transform.rotation = Quaternion.RotateTowards(playerModel.player.transform.rotation, playerModel.requiredRotation, 10f * Time.deltaTime);
    }


  

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Player got a coin!");
            
            playerView.scoreManager.AddScore(10, playerView.scoreText);
            
        }
        else if (other.gameObject.CompareTag("End"))
        {
            Debug.Log("GameOver");
            playerView.addNamePanel.SetActive(true);

        }


    }
}
