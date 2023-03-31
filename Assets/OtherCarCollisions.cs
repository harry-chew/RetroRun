using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCarCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
