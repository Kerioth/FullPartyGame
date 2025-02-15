using System;
using UnityEngine;

public class LevelUI : MonoBehaviour
{
    [SerializeField] private GameObject winScreen, loseScreen;

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

    public void Reset()
    {
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
    
    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
    }

    public void ShowLoseScreen()
    {
        loseScreen.SetActive(true);
    }

    public void NextLevel() => LevelManager.Instance.NextLevel();
    public void RestartLevel() => LevelManager.Instance.RestartLevel();

    public void OpenMenu()
    {
        
    }
}
