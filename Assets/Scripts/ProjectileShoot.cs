using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //When user presses space or left mouse button, shoot a projectile
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
