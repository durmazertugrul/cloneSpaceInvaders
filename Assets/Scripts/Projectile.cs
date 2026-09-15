using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;


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
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the projectile
        }
    }
}
