using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;
    public float spawnDelay = 0.5f;
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextSpawnTime)
        {
            SpawnFruit();
        }
    }

    void SpawnFruit()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject selectedFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Count)];
        Vector2 spawnPosition = new Vector2(mousePosition.x, 3f);
        Instantiate(selectedFruit, spawnPosition, Quaternion.identity);
        nextSpawnTime = Time.time + spawnDelay;
    }
}
