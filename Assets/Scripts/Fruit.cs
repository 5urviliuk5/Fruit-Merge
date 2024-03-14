using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Line"))
        {
            End();
        }
    }

    void End()
    {
        SceneManager.LoadScene("Loose");
    }
}
