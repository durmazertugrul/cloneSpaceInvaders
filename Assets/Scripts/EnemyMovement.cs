using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.5f;

    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boundary") 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z); // Move the enemy down by 1 unit when hitting a boundary
            moveSpeed *= -1; //reverse the direction of movement when hitting a boundary

        }
    }
}
