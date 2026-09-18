using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    private int lives = 3;
    [SerializeField] private Image[] lifeImages; // Array of UI images representing lives
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private GameManager gameManager;

    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyProjectile")
        {
            Destroy(other.gameObject);
            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);

            lives -= 1;
            scoreManager.UpdateScore(-5);

            for (int i = 0; i < lifeImages.Length; i++)
            {
                lifeImages[i].enabled = i < lives;
            }

            if (lives <= 0)
            {
                Destroy(gameObject);
                gameManager.GameOver();
            }
        }

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);

            lives -= 1;
            scoreManager.UpdateScore(-5);

            gameManager.EnemyCounter--;

            for (int i = 0; i < lifeImages.Length; i++)
            {
                lifeImages[i].enabled = i < lives;
            }

            if (gameManager.EnemyCounter <= 0)
            {
                gameManager.WinGame();
            }

            if (lives <= 0)
            {
                Destroy(gameObject);
                gameManager.GameOver();
            }
        }
    }




}
