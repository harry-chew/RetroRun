using UnityEngine;

public class RotateAroundAxis : MonoBehaviour
{
    [SerializeField] private Vector3 rotateAroundThis;
    [SerializeField] private float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateAroundThis, rotateSpeed * Time.deltaTime);
    }
}
