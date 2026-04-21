using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    // public Action<int> OnAddScoreAction;
    public UnityEvent<int> OnAddScoreEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnAddScoreEvent?.Invoke(10);
        }
    }
}
