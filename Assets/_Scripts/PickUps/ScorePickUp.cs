using UnityEngine;

public class ScorePickUp : MonoBehaviour, IPickUp
{
    public void Collect()
    {
        Score.Instance.IncrementScoreMultiplier();
        Destroy(gameObject);
    }
}
