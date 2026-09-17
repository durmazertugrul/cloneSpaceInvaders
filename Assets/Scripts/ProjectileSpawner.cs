using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float spawnTimer;
    [SerializeField] private float spawnMax = 10f;
    [SerializeField] private float spawnMin = 5f;

    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0) //when the timer reaches zero, spawn a projectile and reset the timer
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
    }
}
