using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartCollider : MonoBehaviour
{
    [SerializeField] private UnityEvent OnColliderEnter;
    [SerializeField] private UnityEvent OnColliderExit;
    private bool hasCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasCollision)
        {
            hasCollision = true;
            OnColliderEnter?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !hasCollision)
        {
            hasCollision = true;
            OnColliderExit?.Invoke();
        }
    }
}
