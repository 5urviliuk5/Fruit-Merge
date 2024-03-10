using UnityEngine;

public class Falling : MonoBehaviour
{
    public float fallSpeed = 5f;
    public float stopY = -3.5f;

    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        if (transform.position.y <= stopY)
        {
            transform.position = new Vector2(transform.position.x, stopY);
        }
    }
}
