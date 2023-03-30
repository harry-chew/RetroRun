using UnityEngine;

public class TriggerSpawnNewFloorPiece : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FloorSpawner.Instance.SpawnFloorInFrontOfPlayer();
        }
    }
}
