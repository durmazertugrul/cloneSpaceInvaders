using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 0.1f;
    private float tileHeight;
    private Vector3 startPos;

    private void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        tileHeight = sr.sprite.bounds.size.y; 
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;

        if (transform.position.y <= startPos.y - tileHeight)
        {
            transform.position += Vector3.up * tileHeight;
        }
    }
}