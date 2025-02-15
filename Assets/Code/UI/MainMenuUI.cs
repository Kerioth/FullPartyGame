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
        
        if(PlayerPrefs.HasKey("data"))
        {
            DataSaver.LoadData();
        }
        else
        {
            PlayerData.SetUp();
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void NewGame()
    {
        PlayerData.SetLevel(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
