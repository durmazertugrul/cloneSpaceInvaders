using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    private int lives = 3;
    [SerializeField] private Image[] lifeImages; // Array of UI images representing lives
    [SerializeField] private GameObject explosionPrefab;

    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyProjectile")
        {
            Destroy(other.gameObject); // Destroy the enemy
            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);

            lives -= 1;
            scoreManager.UpdateScore(-5); // Deduct score for losing a life

            for (int i = 0; i < lifeImages.Length; i++)
            {
                    lifeImages[i].enabled = i < lives; // Show the life image
            }

            if (lives <= 0) 
            {             
                Destroy(gameObject); // Destroy the ship
                //game over logic here
            }
        }

    }

   


}
