using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float horizontalInput;


    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal"); // Gets horizontal input from the player: A/Left = -1, D/Right = 1

        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime); // Moves the player horizontally based on the input direction without needing a separate direction check.
    }
}