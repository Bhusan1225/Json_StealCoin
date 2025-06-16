using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public static GameSession instance;  // simple singleton

    private string playerName = "Player";
    private int score = 0;


   // [SerializeField] Button PlayButton;
    void Awake()
    {
        if (instance == null) 
        { 
            instance = this; DontDestroyOnLoad(gameObject); 
        }
        else 
        { 
            Destroy(gameObject); 
        }
    }


   
    public void LoadGameplayScene(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
        playerName = "Player";  // Reset player name when starting a new game
        score = 0;
    }

    public string PlayerName
    {
        get => playerName;
        set => playerName = value;
    }

    public int Score
    {
        get => score;
        set => score = value;
    }
}
