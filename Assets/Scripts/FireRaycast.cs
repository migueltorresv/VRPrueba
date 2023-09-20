using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireRaycast : MonoBehaviour
{
    [SerializeField] private float rangeRay;
    [SerializeField] private Transform startPosition;
    [SerializeField] private LayerMask aimLayerMask = new LayerMask();
    [SerializeField] private LayerMask targetHitLayerMask = new LayerMask();
    [SerializeField] private UnityEvent<Vector3> OnTargetHit;
    [SerializeField] private UnityEvent<Vector3> OnTargetNoHit;
    
    public void Fire()
    {
        Ray ray = new Ray(startPosition.position, startPosition.forward);
        Transform hitTransform = null;
        if (Physics.Raycast(ray, out RaycastHit hit, rangeRay, aimLayerMask))
        {
            hitTransform = hit.transform;
            int targetLayer = 1 << (LayerMask)hitTransform.gameObject.layer;
            if (targetLayer == targetHitLayerMask.value)
            {
                OnTargetHit?.Invoke(hit.point);
                hitTransform.GetComponent<TargetHitted>()?.Hit(hit.point);
            }
            else
            {
                OnTargetNoHit?.Invoke(hit.point);
            }
        }
    }
}
