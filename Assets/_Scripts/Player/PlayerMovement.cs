using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private void OnEnable()
    {
        PlayerInput.OnDirectionChange += HandleDirectionChange;
    }

    private void HandleDirectionChange(float dir)
    {
        Debug.Log("Position: " + transform.position + " | Direction: " + dir);
        if (transform.position.x + dir > 4.5f || transform.position.x + dir < -4.5f ) return;
        else gameObject.transform.Translate(new Vector3(dir * 2f, 0, 0));
    }

    private void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
