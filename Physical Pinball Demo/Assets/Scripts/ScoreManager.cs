using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int Score;
    public Text ScoreText;

    public static ScoreManager Instace;
    private void Awake()
    {
        Instace = this;
    }
    public void AddScore(int count)
    {
       Score += count;
       ScoreText.text = Score.ToString();

    }
}
