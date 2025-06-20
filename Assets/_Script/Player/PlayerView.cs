using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerView : MonoBehaviour
{


    PlayerController playerController;

    [Header("View")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI inputNameText;
    public GameObject addNamePanel;


    [Header("Model")]
    PlayerModel playerModel;
    [SerializeField] int speed;
    [SerializeField] GameObject playerGameObject;
    [SerializeField] CameraManager mainCamera;

    [Header("Score")]
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
        playerModel = new PlayerModel(speed, playerGameObject, mainCamera);
        playerController = new PlayerController(playerModel, this);


        ///////////

        nameText.text = GameSession.instance.PlayerName; // Default name
        scoreText.text = "Score: " + GameSession.instance.Score;
    }

    // Update is called once per frame
    void Update()
    {
        playerController.Update();
    }

   
    private void OnTriggerEnter(Collider other)
    {

        playerController.OnTriggerEnter(other);
        FindObjectOfType<GameSession>().Score += 10;
        scoreText.text = "Score: " + GameSession.instance.Score;
    }

    public void SetName(string name)
    {
        nameText.text = name;
    }


}



