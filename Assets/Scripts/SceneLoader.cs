using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private UnityEvent OnStartScene;
    private void Start()
    {
        OnStartScene?.Invoke();
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
