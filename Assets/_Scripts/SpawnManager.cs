using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform obstacles;
    [SerializeField] private Transform stars;
    [SerializeField] private Transform lives;
    [SerializeField] private float initialSpawnDelay = 5f;
    [SerializeField] private float spawnAfter = 5f;

    private float initialStarSpawnDelay = 8f;
    private float starSpawnAfter = 9f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacles", initialSpawnDelay, spawnAfter);
        InvokeRepeating("SpawnStars", initialStarSpawnDelay, starSpawnAfter);
        InvokeRepeating("SpawnLives", initialStarSpawnDelay + 8f, starSpawnAfter + 5f);
    }

    private void SpawnObstacles()
    {
        Transform spawnedObstacles = Instantiate(obstacles, transform);
        spawnedObstacles.position = new Vector3(0, 6.5f, 0);
        spawnedObstacles.gameObject.SetActive(true);
        Transform randomChild = spawnedObstacles.GetChild(Random.Range(0, spawnedObstacles.childCount));
        randomChild.gameObject.SetActive(false);
    }

    private void SpawnStars()
    {
        Transform spawnedObstacles = Instantiate(stars, transform);
        spawnedObstacles.position = new Vector3(0, 6.5f, 0);
        spawnedObstacles.gameObject.SetActive(true);
        foreach (Transform child in spawnedObstacles)
        {
            child.gameObject.SetActive(false);
        }

        Transform randomChild = spawnedObstacles.GetChild(Random.Range(0, spawnedObstacles.childCount));
        randomChild.gameObject.SetActive(true);
    }

    private void SpawnLives()
    {
        Transform spawnedObstacles = Instantiate(lives, transform);
        spawnedObstacles.position = new Vector3(0, 6.5f, 0);
        spawnedObstacles.gameObject.SetActive(true);
        foreach (Transform child in spawnedObstacles)
        {
            child.gameObject.SetActive(false);
        }

        Transform randomChild = spawnedObstacles.GetChild(Random.Range(0, spawnedObstacles.childCount));
        randomChild.gameObject.SetActive(true);
    }
}
