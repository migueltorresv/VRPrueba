using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private Transform startPoint;

    public void Fire()
    {
        Instantiate(prefabBullet, startPoint.position, startPoint.rotation);
    }
}
