using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] pickUps;
    [SerializeField] private Transform[] pickUpSpawnPoints;

    [SerializeField] private float spawnTimer;

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            SpawnPickUp();
            spawnTimer = Random.Range(.5f, 1.5f);
        }
    }

    public void SpawnPickUp()
    {
        int randomIndex = Random.Range(0, pickUps.Length);
        int randomSpawnPointIndex = Random.Range(0, pickUpSpawnPoints.Length);
        Instantiate(pickUps[randomIndex], pickUpSpawnPoints[randomSpawnPointIndex].position, Quaternion.identity);
    }
}
