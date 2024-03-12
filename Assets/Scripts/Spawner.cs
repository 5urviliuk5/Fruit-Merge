using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public List<GameObject> fruitPrefabs;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject selectedFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Count)];
            Vector2 spawnPosition = new Vector2(mousePosition.x, 4f);
            Instantiate(selectedFruit, spawnPosition, Quaternion.identity);
        }
    }
}