using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    [SerializeField] private float secondsToDestroy;
    void Start()
    {
        Destroy(gameObject, secondsToDestroy); 
    }
}
