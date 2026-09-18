using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
public class GameManager : MonoBehaviour
{
    public int EnemyCounter = 15;

    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject WinUI;
    [SerializeField] private GameObject LivesUI;
    [SerializeField] private GameObject ScoreUI;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Enemies;
    void Start()
    {
        mainMenuUI.SetActive(true); // Show the main menu UI at the start of the game
        gameOverUI.SetActive(false);
        WinUI.SetActive(false);
        LivesUI.SetActive(false);
        ScoreUI.SetActive(false);
        Player.SetActive(false);
        Enemies.SetActive(false);
    }

    public void StartGame()
    {
        mainMenuUI.SetActive(false);
        LivesUI.SetActive(true);
        ScoreUI.SetActive(true);
        Player.SetActive(true);
        Enemies.SetActive(true);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        mainMenuUI.SetActive(false);
        LivesUI.SetActive(false);
        ScoreUI.SetActive(false);
        Player.SetActive(false);
        Enemies.SetActive(false);
    }

    public void WinGame()
    {
        WinUI.SetActive(true);
        mainMenuUI.SetActive(false);
        LivesUI.SetActive(false);
        ScoreUI.SetActive(false);
        Player.SetActive(false);
        Enemies.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
