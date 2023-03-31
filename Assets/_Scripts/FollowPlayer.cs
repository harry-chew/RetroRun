using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;

    private void LateUpdate()
    {
        transform.position = new Vector3(0, 4.4f, playerTransform.position.z - 10f);
    }
}
