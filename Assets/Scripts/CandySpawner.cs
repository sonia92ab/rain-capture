using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject CandyPrefab;
    public float spawnInterval = 1f;
    public float xRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnCandybehavior", 1f, spawnInterval);
    }

    void SpawnCandybehavior()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 6, 0);
        GameObject Candy = Instantiate(CandyPrefab, spawnPos, Quaternion.identity);
    }
}
