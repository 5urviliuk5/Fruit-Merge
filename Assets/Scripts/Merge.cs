using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Merge : MonoBehaviour
{
    int ID;
    public GameObject mergedFruit;

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
            if (O.CompareTag("9"))
            {
                SceneManager.LoadScene("Final");
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
