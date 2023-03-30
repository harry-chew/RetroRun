using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private float currentGameTime = 0f;
    [SerializeField] private bool isGameRunning = false;

    private void Start()
    {
        currentGameTime = 0f;
        isGameRunning = true;
    }

    private void Update()
    {
        if(isGameRunning)
            currentGameTime += Time.deltaTime;
    }

    public float GetCurrentGameTime()
    {
        return currentGameTime;
    }
}
