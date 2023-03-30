using System;
using UnityEngine;

public class UpdateScoreMultiplierUI : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI scoreMultiplierText;
    private void OnEnable()
    {
        Score.OnScoreMultiplierChanged += UpdateScoreMultiplier;
    }

    private void UpdateScoreMultiplier(float scoreMultiplier)
    {
        scoreMultiplierText.text = scoreMultiplier.ToString("F1") + "x";
    }
}
