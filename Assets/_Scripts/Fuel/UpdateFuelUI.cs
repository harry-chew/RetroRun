using System;
using UnityEngine;

public class UpdateFuelUI : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text fuelText;
    private void OnEnable()
    {
        Fuel.OnFuelChanged += HandleOnFuelChanged;
    }

    private void HandleOnFuelChanged(float fuel)
    {
        fuelText.text = fuel.ToString("F2") + "l :Fuel";
    }
}
