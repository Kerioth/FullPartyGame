using System;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<LevelPrefab> levelPrefabs;
    public PlayerPrefab playerPrefab;

    public static LevelManager Instance;
    public int currentLevel = 0;
    public int levelStars = 0;

    public event Action OnLevelStarted;
    public event Action<bool> OnLevelFinished;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartLevel(currentLevel);
    }

    public void NewStart() => StartLevel(1);

    public void NextLevel()
    {
        levelPrefabs[currentLevel].gameObject.SetActive(false);
        currentLevel++;
        if (currentLevel >= levelPrefabs.Count) currentLevel = 0;
        StartLevel(currentLevel);
    }
    public void StartLevel(int level)
    {
        PlayerData.SetLevel(level);
        AudioBox.Instance.Stop("Menu");
        AudioBox.Instance.Play("Level");
        levelStars = 0;
        
        levelPrefabs[currentLevel].gameObject.SetActive(true);
        levelPrefabs[currentLevel].SetUp();
        OnLevelStarted?.Invoke();
    }

    public void RestartLevel() => StartLevel(currentLevel);

    public void LoseLevel()
    {
        OnLevelFinished?.Invoke(false);
    }

    public void EndLevel()
    {
        levelStars = 3;
        PlayerData.LevelStars = levelStars;
        OnLevelFinished?.Invoke(true);
        PlayerData.SetLevelStars();
    }
}
