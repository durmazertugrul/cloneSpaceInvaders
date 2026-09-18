using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score;
    private int highScore;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private TMP_Text scoreTextGO;
    [SerializeField] private TMP_Text highScoreTextGO;
    [SerializeField] private TMP_Text scoreTextWin;
    [SerializeField] private TMP_Text highScoreTextWin;

    void Start()
    {
        scoreText.text = "Score:  " + score.ToString(); // Initialize the score display
        highScoreText.text = "High Score:  " + highScore.ToString(); // Initialize the high score display
        scoreTextGO.text = "Score:  " + score.ToString(); // Initialize the score display for Game Over
        highScoreTextGO.text = "High Score:  " + highScore.ToString(); // Initialize the high score display for Game Over
        scoreTextWin.text = "Score:  " + score.ToString(); // Initialize the score display for Win
        highScoreTextWin.text = "High Score:  " + highScore.ToString(); // Initialize the high score display for Win
    }

    public void UpdateScore(int points) 
    {
        score += points;
        scoreText.text = "Score:  " + score.ToString();
        scoreTextGO.text = "Score:  " + score.ToString(); // Update the score display for Game Over
        scoreTextWin.text = "Score:  " + score.ToString(); // Update the score display for Win

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        highScoreText.text = "High Score:  " + highScore.ToString();
        highScoreTextGO.text = "High Score:  " + highScore.ToString(); // Update the high score display for Game Over
        highScoreTextWin.text = "High Score:  " + highScore.ToString(); // Update the high score display for Win
    }

    
}
