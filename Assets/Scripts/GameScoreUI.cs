using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScoreUI : MonoBehaviour
{
    int goalsPlayerOne;
    int goalsPlayerTwo;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScore()
    {
        goalsPlayerOne = 0;
        goalsPlayerTwo = 0;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = goalsPlayerOne + " : " + goalsPlayerTwo;
    }

    public void GoalScoredPlayerOne()
    {
        goalsPlayerOne++;
        UpdateScore();
    }

    public void GoalScoredPlayerTwo()
    {
        goalsPlayerTwo++;
        UpdateScore();
    }
}
