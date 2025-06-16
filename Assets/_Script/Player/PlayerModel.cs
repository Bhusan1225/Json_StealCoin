using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerModel 
{
    //variables
    public int speed;
    public GameObject player;
    public CameraManager mainCamera;
    
    public Quaternion requiredRotation;


    public PlayerModel(int speed, GameObject player, CameraManager mainCamera)
    {
        this.speed = speed;
        this.player = player;
        this.mainCamera = mainCamera;
        requiredRotation = Quaternion.identity; // Initialize to identity rotation
    }

}
