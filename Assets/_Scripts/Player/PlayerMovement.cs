using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void OnEnable()
    {
        PlayerInput.OnDirectionChange += HandleDirectionChange;
    }

    private void HandleDirectionChange(int dir)
    {
        if (transform.position.x + dir > 4 || transform.position.x < -4 ) return;
        else gameObject.transform.Translate(new Vector3(dir * 2, 0, 0));
    }
}
