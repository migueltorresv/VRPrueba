using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    [ContextMenu(nameof(AddForce))]
    public void AddForce(Vector3 point)
    {
        _rigidbody.AddExplosionForce(_explosionForce, point, _explosionRadius);
    }
}
