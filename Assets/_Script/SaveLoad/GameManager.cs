using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private string filePath;
    // Start is called before the first frame update
    private void Start()
    {
        filePath = Path.Combine(Application.persistentDataPath, "data.json");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSave()
    {
        //string name = nameText.text;
        //int age = 0;
        //int.TryParse(ageText.text, out age);

        //Data d = new Data();
        //d.name = name;
        //d.age = age;

        //string jsonText = JsonUtility.ToJson(d, true);
        //File.WriteAllText(filePath, jsonText);


        Debug.Log("Data saved!");
    }

}
