using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] GameEvent _event;
    [SerializeField] UnityEvent _unityEvent; //thing to do on trigger

    public void Raise()
    {
        _unityEvent?.Invoke();
    }

    private void Awake()
    {
        _event.Register(this);
    }

    private void OnDestroy()
    {
        _event.Deregister(this);
    }
}
