using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static event Action<float> OnDirectionChange;

    public float dir = 0;
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            dir = -1;
            OnDirectionChange?.Invoke(dir);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            dir = 1;
            OnDirectionChange?.Invoke(dir);
        }
        //dir = 0;
    }
}
