using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameplaySaver : MonoBehaviour
{
    public TMP_InputField nameInput;   // drag this in from Inspector

    public void SaveAndExit()
    {
        //var gameSession = FindObjectOfType<GameSession>();
        var gameSession = GameSession.instance;

        // If player name is not set (means it's a new game), get it from input
        if (string.IsNullOrEmpty(gameSession.PlayerName))
            gameSession.PlayerName = nameInput.text;

        // Create a PlayerData object to hold name and score
        var data = new PlayerData
        {
            playerName = gameSession.PlayerName,
            score = gameSession.Score
        };

        // Save to disk using SaveManager
        SaveManager.Save(data);

        // Return to Lobby scene
        SceneManager.LoadScene(0);
    }
}
