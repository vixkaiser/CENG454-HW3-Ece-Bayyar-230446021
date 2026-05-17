using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnInterval = 2f;

    private float timer;

    private void Update()
    {
        if (CoreHealth.gameOver)
        return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 0.5f, Random.Range(-8, 8));

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}