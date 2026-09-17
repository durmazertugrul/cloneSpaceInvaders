using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int highScore;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;

    void Start()
    {
        scoreText.text = "Score:  " + score.ToString(); // Initialize the score display
        highScoreText.text = "High Score:  " + highScore.ToString(); // Initialize the high score display
    }

    public void UpdateScore(int points) 
    {
        score += points;
        scoreText.text = "Score:  " + score.ToString();
        
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        highScoreText.text = "High Score:  " + highScore.ToString();
    }

    
}
