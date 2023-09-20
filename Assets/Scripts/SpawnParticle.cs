using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem _greenParticleSystem;
    [SerializeField] private ParticleSystem _redParticleSystem;
    private ParticleSystem greenParticleLocal;
    private ParticleSystem redParticleLocal;
    
    public void SpawnGreen(Vector3 position)
    {
        if (greenParticleLocal == null)
        {
            greenParticleLocal = Instantiate(_greenParticleSystem, position, quaternion.identity);
        }
        else
        {
            greenParticleLocal.transform.position = position;
            greenParticleLocal.Play(true);
        }
    }

    public void SpawnRed(Vector3 position)
    {
        if (redParticleLocal == null)
        {
            redParticleLocal = Instantiate(_redParticleSystem, position, quaternion.identity);
        }
        else
        {
            redParticleLocal.transform.position = position;
            redParticleLocal.Play(true);
        }
    }
}
