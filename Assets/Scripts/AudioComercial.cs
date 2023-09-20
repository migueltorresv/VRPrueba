using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioComercial : MonoBehaviour
{
    [SerializeField] private AudioClip audioclip;
    [SerializeField] [Range(0,10)] private float delayTimeStartSound;
    [SerializeField] private UnityEvent OnStartSound;
    [SerializeField] private UnityEvent OnFinishSound;
    private AudioSource _audiosource;
    private float _duration;

    private void Start()
    {
        Invoke(nameof(Initialize), delayTimeStartSound);
    }

    public void Initialize()
    {
        _audiosource = GetComponent<AudioSource>();
        _audiosource.clip = audioclip;
        _audiosource.Play();
        OnStartSound?.Invoke();
        _duration = audioclip.length;
        StartCoroutine(WaitForSound());
    }

    private IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(_duration);
        print("FinishAudio");
        OnFinishSound?.Invoke();
    }
}
