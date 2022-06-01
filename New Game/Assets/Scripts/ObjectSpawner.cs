using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] trianglePrefabs;
    private Vector3 spawnObstaclePosition;
    
    void Update()
    {
        float distanceToHorizion = Vector3.Distance(player.gameObject.transform.position, spawnObstaclePosition);

        if (distanceToHorizion < 120)
        {
            SpawnTriangles();
        }
    }

    void SpawnTriangles()
    {
        spawnObstaclePosition = new Vector3(0, 0, spawnObstaclePosition.z + 30);
        Instantiate (trianglePrefabs[(Random.Range(0, trianglePrefabs.Length))], spawnObstaclePosition, Quaternion.identity);
    }
}
