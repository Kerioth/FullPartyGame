using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<LevelPrefab> levelPrefabs;
    [SerializeField] private PlayerPrefab playerPrefab;
    
    public static LevelManager Instance;
    public int currentLevel = 0;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    public void NewStart() => StartLevel(1);

    public void NextLevel()
    {
        currentLevel++;
        StartLevel(currentLevel);
    }
    public void StartLevel(int level)
    {
        currentLevel = level;
        LevelUI.instance.Reset();
    }

    public void RestartLevel() => StartLevel(currentLevel);

    public void LoseLevel()
    {
        LevelUI.instance.ShowLoseScreen();
    }

    public void EndLevel()
    {
        LevelUI.instance.ShowWinScreen();
    }
}
