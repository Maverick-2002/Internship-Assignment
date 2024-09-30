using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public GameObject[] shapePrefabs;  
    public Transform[] spawnPoints;    

    void Start()
    {
        SpawnShapes();
    }

    void SpawnShapes()
    {

        for (int i = 0; i < 12; i++)
        {
            GameObject shapePrefab = shapePrefabs[Random.Range(0, shapePrefabs.Length)];
            Transform spawnPoint = spawnPoints[i];
            Instantiate(shapePrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
