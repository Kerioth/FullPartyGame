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


    public void StartLevel()
    {
        
    }

    public void RestartLevel()
    {
        
    }

    public void EndLevel()
    {
        
    }
}
