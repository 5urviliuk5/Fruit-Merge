using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;
using TMPro;

public class Merge : MonoBehaviour
{
    int ID;
    public GameObject mergedFruit;
    public TextMesh scoreText;

    void Start()
    {
        ID = GetInstanceID();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<SpriteRenderer>().color == GetComponent<SpriteRenderer>().color)
        {
            if (ID < other.gameObject.GetComponent<Merge>().ID) return;
            GameObject O = Instantiate(mergedFruit, transform.position, Quaternion.identity) as GameObject;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
