using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public int score;

    public static ScoreManager intstace;
    private void Awake()
    {
        intstace = this;
    }
    public void AddScore(int score)
    {
        this.score += score;
        UIManager.instace.Scoure.text = this.score.ToString();
        print(score.ToString());
    }
}
