using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;
    public float spawnHeight = 6f;
    public float spawnWidth = 8f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            GameObject selectedFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Count)];

            Vector2 spawnPosition = new Vector2(mousePosition.x, mousePosition.y);
            Instantiate(selectedFruit, spawnPosition, Quaternion.identity);
        }
    }

    public GameObject GetNextFruitPrefab()
    {
        return fruitPrefabs[nextFruitIndex];
    }

    public bool HasNextFruitChanged()
    {
        return true;
    }
}
