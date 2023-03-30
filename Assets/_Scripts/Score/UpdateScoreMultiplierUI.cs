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
        int scoreMultiplierInt = (int)scoreMultiplier;
        scoreMultiplierText.text = scoreMultiplierInt.ToString() + "x";
    }
}
