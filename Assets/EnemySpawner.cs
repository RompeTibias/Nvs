using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    [Header("Rango de aparición en X")]
    public float minX = -3f;
    public float maxX = 3f;

    [Header("Altura de aparición (Y)")]
    public float spawnY = 5f;

    [Header("Tiempo entre spawns")]
    public float spawnInterval = 5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), spawnInterval, spawnInterval);
    }

    public void SpawnEnemy()
    {
        float randomX = Random.Range(minX, maxX);
        Vector2 spawnPos = new Vector2(randomX, spawnY);

        GameObject newEnemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        newEnemy.GetComponent<Enemy>().spawner = this;
    }
}

