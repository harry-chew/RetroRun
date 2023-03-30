using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void OnEnable()
    {
        PlayerInput.OnDirectionChange += HandleDirectionChange;
    }

    private void HandleDirectionChange(int dir)
    {
        if (transform.position.x + dir > 4.5f || transform.position.x < -4.5f ) return;
        else gameObject.transform.Translate(new Vector3(dir * 2, 0, 0));
    }

    private void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
