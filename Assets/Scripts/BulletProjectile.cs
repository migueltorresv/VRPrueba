using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody _bulletRigidbody;
    [SerializeField] private LayerMask lakerMaskAllow = new LayerMask();
    [SerializeField] private UnityEvent OnCollitionBulletEvent;
    private void Awake()
    {
        _bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _bulletRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
