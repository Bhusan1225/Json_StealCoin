using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;      // if using TMP

public class LobbyLoader : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void ConfirmLoad()
    {
        var data = SaveManager.Load(nameInput.text);
        if (data != null)
        {
            var gameSession = FindObjectOfType<GameSession>();
            gameSession.PlayerName = data.playerName;
            gameSession.Score = data.score;
            SceneManager.LoadScene("Gameplay");
        }
        else
        {
            Debug.Log("No save for that name!");
        }
    }
}
