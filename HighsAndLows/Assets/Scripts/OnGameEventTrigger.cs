using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGameEventTrigger : MonoBehaviour
{
    [SerializeField] GameEvent _event;

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            _event?.Invoke();
        }
    }
}
