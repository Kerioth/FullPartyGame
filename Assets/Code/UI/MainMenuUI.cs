using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        PlayerData.SetLevel(level);
        SceneManager.LoadScene(level);
    }

}
