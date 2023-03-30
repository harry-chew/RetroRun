using TMPro;
using UnityEngine;

public class UpdateTimerUI : MonoBehaviour
{
    [SerializeField] private GameTimer gameTimer;
    [SerializeField] private TMP_Text timerText;

    void Update()
    {
        timerText.text = "Time: " + gameTimer.GetCurrentGameTime().ToString("F2") + "s";
    }
}
