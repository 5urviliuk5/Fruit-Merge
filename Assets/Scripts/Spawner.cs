using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;
    public float spawnRate = 1f; 
    public float spawnHeight = 6f;
    public float spawnWidth = 8f;

    private void Update()
    {
        SpawnFruit();
    }

    void Click()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float randomX = Random.Range(-spawnWidth / 2f, spawnWidth / 2f);
        Vector2 spawnPosition = new Vector2(randomX, mousePosition.y);

        for (int i = 0; i < fruitPrefabs.Count; i++)
        {
            foreach (var fruit in fruitPrefabs)
            {
                Instantiate(fruit, spawnPosition, Quaternion.identity);
            }
        }
    }

    void SpawnFruit()
    {
        Click();        
    }
}
