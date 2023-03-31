using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private GameObject[] gameUI;
    [SerializeField] private GameObject menuUI;
    [SerializeField] private TMPro.TextMeshProUGUI scoreText;

    [SerializeField] private float finalScore;
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

    public void GameOver()
    {
        finalScore = Score.Instance.GetScore();
        scoreText.text = finalScore.ToString("0");
        //hide UI elements
        foreach (var ui in gameUI)
        {
            ui.SetActive(false);
        }
        //show game over screen
        menuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void AddFinalScore(float scoreToAdd)
    {
        finalScore = scoreToAdd;
    }
}
