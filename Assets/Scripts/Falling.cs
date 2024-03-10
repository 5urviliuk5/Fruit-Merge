using UnityEngine;

public class Falling : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}