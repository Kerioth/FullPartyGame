using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private int levelNum;
    [SerializeField] private TMP_Text levelText;
    
    [SerializeField] private List<GameObject> levelStars;

    private void Start()
    {
        levelText.text = levelNum.ToString();
        int stars = PlayerData.data.playerLevels[levelNum-1].stars;

        for (int i = 0; i < levelStars.Count; i++)
        {
            levelStars[i].SetActive(i <= stars - 1);
        }
        
        GetComponent<Button>().onClick.AddListener(OpenLevel);
    }

    private void OnDisable()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
    }

    public void OpenLevel()
    {
        PlayerData.SetLevel(levelNum);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
