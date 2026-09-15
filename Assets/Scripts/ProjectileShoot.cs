using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }

       
    }

}
