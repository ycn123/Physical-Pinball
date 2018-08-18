using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int Score;
    public Text ScoreText;
    public Text HighestScoreText;


    public static ScoreManager Instace;
    private void Awake()
    {
        Instace = this;
        if(PlayerPrefs.HasKey("HighestScore"))
        HighestScoreText.text = PlayerPrefs.GetInt("HighestScore").ToString();

    }
    public void AddScore(int count)
    {
        Score += count;
        ScoreText.text = Score.ToString();

    }
    public void GameOverRecord() {
        PlayerPrefs.SetInt("HighestScore", Score);
    }
}
