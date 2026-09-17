using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime; // Move the projectile downwards
       
        if (transform.position.y <= -6f)
        {
            Destroy(gameObject);
        }

    }
}
