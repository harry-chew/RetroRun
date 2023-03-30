using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static event Action<int> OnDirectionChange;

    public int dir = 0;
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
        dir = 0;
    }
}
