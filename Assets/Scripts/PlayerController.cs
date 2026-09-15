using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); // Gets horizontal input from the player: A/Left = -1, D/Right = 1

    }

    private void FixedUpdate()
    {
        // Move the ship without any titration when the player touch the boundary of the screen
        rb2d.linearVelocity = Vector2.right * horizontalInput * speed;
    }



}