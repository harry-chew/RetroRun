using TMPro;
using UnityEngine;

public class UpdateTimerUI : MonoBehaviour
{
    [SerializeField] private GameTimer gameTimer;
    [SerializeField] private TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "Time: " + gameTimer.GetCurrentGameTime().ToString("F2") + "s";
    }
}
