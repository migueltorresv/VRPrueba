using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent OnStartGame;
    [SerializeField] private UnityEvent OnEndGame;
    private void Start()
    {
        OnStartGame.Invoke();
    }

    private void Update()
    {
        Application.runInBackground = true;
    }

    public void EndGame()
    {
        OnEndGame.Invoke();
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
    
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RunInBackground()
    {
        Application.runInBackground = true;
    }
}
