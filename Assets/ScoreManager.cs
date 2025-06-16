using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    int score;

    public void AddScore(int addscore, TextMeshProUGUI scoreText)
    {
        score += addscore;
        scoreText.text = "Score: " + score;
    }
}
