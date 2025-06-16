using System.IO;
using UnityEngine;

[System.Serializable]                // <-- needed for JsonUtility
public class PlayerData
{
    public string playerName;
    public int score;
}

public static class SaveManager
{


    private static string folder = Application.persistentDataPath + "/saves";


    
    public static void Save(PlayerData data) //save data to json file
    {
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);

        string json = JsonUtility.ToJson(data);   ///////////////////////////////////////Adding the player data
        File.WriteAllText($"{folder}/{data.playerName}.json", json);
    }

    public static PlayerData Load(string name) //load data from json file
    {
        string path = $"{folder}/{name}.json";
        if (!File.Exists(path)) return null;

        string json = File.ReadAllText(path);
        
        return JsonUtility.FromJson<PlayerData>(json); ///////////////////////////////////////returning the player data
    }
}
