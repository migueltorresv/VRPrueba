using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetHitted : MonoBehaviour
{
    [SerializeField] private UnityEvent<Vector3> OnHit;
    
    public void Hit(Vector3 point)
    {
        OnHit?.Invoke(point);
    }
}
