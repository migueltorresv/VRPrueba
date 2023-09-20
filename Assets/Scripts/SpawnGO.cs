using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGO : MonoBehaviour
{
    [SerializeField] private GameObject prefabForSpawn;
    
    public void Spawn(Vector3 position)
    {
        Instantiate(prefabForSpawn, position, Quaternion.identity);
    }
}
