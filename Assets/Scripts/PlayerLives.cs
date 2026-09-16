using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    private int lives = 3;
    [SerializeField] private Image[] lifeImages; // Array of UI images representing lives
    [SerializeField] private GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject); // Destroy the enemy
            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);

            lives -= 1;

            for (int i = 0; i < lifeImages.Length; i++)
            {
                if ( i < lives) 
                {
                    lifeImages[i].enabled = true; // Show the life image
                }
                else 
                {
                    lifeImages[i].enabled = false; // Hide the life image
                }
            }

            if (lives <= 0) 
            {             
                Destroy(gameObject); // Destroy the ship
                //game over logic here
            }
        }
    }

}
