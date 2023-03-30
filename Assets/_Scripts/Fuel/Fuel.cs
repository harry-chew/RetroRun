using System;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public static Action<float> OnFuelChanged;
    [SerializeField] private float fuel = 100f;
    [SerializeField] private bool isFuelRunning = false;


    private void Start()
    {
        fuel = 100f;
        isFuelRunning = true;
    }

    private void Update()
    {
        if (isFuelRunning)
            fuel -= Time.deltaTime;
        OnFuelChanged?.Invoke(fuel);
    }

    public void ConsumeFuel(float amount)
    {
        fuel -= amount;
    }

    public void Refuel(float amount)
    {
        fuel += amount;
    }
    
    public float GetFuel()
    {
        return fuel;
    }
}
