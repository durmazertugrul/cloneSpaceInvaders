using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private GameObject explosionPrefab; // Reference to the explosion prefab


    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime); //move to upwards direction

        if (transform.position.y > 6f) //when the projectile goes off the screen, destroy it
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, other.transform.position, Quaternion.identity); // Instantiate the explosion effect at the enemy's position
            }
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the projectile
        }
    }
}
