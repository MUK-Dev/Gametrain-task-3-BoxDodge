using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    [SerializeField] private float speed = 15f;

    private float xRange = 7.5f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector2.right * h * speed * Time.deltaTime);
    }
}
