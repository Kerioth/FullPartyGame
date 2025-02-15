using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public static MainMenuUI instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void StartLevel(int level)
    {
        LevelManager.Instance.StartLevel(level);
    }
}