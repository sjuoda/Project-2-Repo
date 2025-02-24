using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        SpawnPotion(0,1);
        SpawnPotion(90,3);
        SpawnPotion(180,5);
        SpawnPotion(270,7);
        
    }

    void SpawnPotion(int angle, int radius)
    {
        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        Vector3 spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }
}

