using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    private string playerName = "";
    private int score = 0;

    public static GameSession instance;          // simple singleton
    void Awake()
    {
        if (instance == null) { instance = this; DontDestroyOnLoad(gameObject); }
        else { Destroy(gameObject); }
    }

    public void LoadGameplayScene(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
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
