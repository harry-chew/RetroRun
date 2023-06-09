using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.GetComponent<IPickUp>() != null)
        {
            col.GetComponent<IPickUp>().Collect();
        }   
    }
}