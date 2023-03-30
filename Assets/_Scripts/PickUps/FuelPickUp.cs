using UnityEngine;

public class FuelPickUp : MonoBehaviour, IPickUp
{
    public void Collect()
    {
        Fuel.Instance.Refuel(10f);
        Destroy(gameObject);
    }
}
