using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        if (other.collider.CompareTag("Life"))
        {
            BoxDodgeGameManager.Instance.IncreaseLife();
            Destroy(other.collider.gameObject);
        }
        else if (other.collider.CompareTag("Obstacle"))
        {
            BoxDodgeGameManager.Instance.ReduceLife();
        }
        else if (other.collider.CompareTag("Star"))
        {
            BoxDodgeGameManager.Instance.IncreaseStars();
            Destroy(other.collider.gameObject);
        }
    }
}
