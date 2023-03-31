using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Action<float> OnScoreMultiplierChanged;
    
    [SerializeField] private float scoreMultiplier = 1f;
    [SerializeField] private float score = 0f;

    public static Score Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (scoreMultiplier > 1.0f)
        {
            scoreMultiplier -= Time.deltaTime;
            OnScoreMultiplierChanged?.Invoke(scoreMultiplier);
        }
        else 
            scoreMultiplier = 1.0f;
        
        AddScore(Time.deltaTime);
    }

    public void IncrementScoreMultiplier()
    {
        scoreMultiplier *= 2f;
        OnScoreMultiplierChanged?.Invoke(scoreMultiplier);
    }


    public void AddScore(float scoreToAdd)
    {
        score += scoreToAdd * scoreMultiplier;
    }

    public float GetScore()
    {
        return score;
    }

}
