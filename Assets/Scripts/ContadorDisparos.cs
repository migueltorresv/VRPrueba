using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ContadorDisparos : MonoBehaviour
{
    private int _scoreShoot = 0;
    [SerializeField] private UnityEvent<int> OnScoreAdded;

    public void AddScore()
    {
        _scoreShoot++;
        OnScoreAdded?.Invoke(_scoreShoot);
    }
}
