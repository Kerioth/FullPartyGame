using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUI : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    
    [SerializeField] private List<GameObject> levelStars;

    public static LevelUI instance;
    private void Awake()
    {
        Reset();
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        LevelManager.Instance.OnLevelStarted += Reset;
        LevelManager.Instance.OnLevelFinished += ShowEndScreen;
    }
    
    private void OnDisable()
    {
        LevelManager.Instance.OnLevelStarted -= Reset;
        LevelManager.Instance.OnLevelFinished -= ShowEndScreen;
    }

    public void Reset()
    {
        winScreen.SetActive(false);
        // loseScreen.SetActive(false);
    }

    public void ShowEndScreen(bool isWin)
    {
        if (isWin) ShowWinScreen();
        // else ShowLoseScreen();
    }
    
    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
        AudioBox.Instance.Play("Win");

        int stars = LevelManager.Instance.levelStars;
        
        for (int i = 0; i < levelStars.Count; i++)
        {
            levelStars[i].SetActive(i <= stars - 1);
        }
    }

    // public void ShowLoseScreen()
    // {
    //     loseScreen.SetActive(true);
    // }

    public void NextLevel()
    {
        AudioBox.Instance.Play("Tap");
        LevelManager.Instance.NextLevel();
    }
    public void RestartLevel()
    { 
        AudioBox.Instance.Play("Tap");
        LevelManager.Instance.RestartLevel();
    }

    public void OpenMenu()
    {
        AudioBox.Instance.Play("Tap");
        SceneManager.LoadScene(0);
    }
}
