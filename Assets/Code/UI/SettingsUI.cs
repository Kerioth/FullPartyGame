using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] private GameObject resetText;

    private void OnBecameVisible()
    {
        resetText.SetActive(false);
    }

    public void ToggleMusic(bool isOn)
    {
        AudioBox.Instance.MusicSwitch(isOn);
    }
    
    public void ToggleSounds(bool isOn)
    {
        AudioBox.Instance.SoundSwitch(isOn);
    }

    public void RestartGame()
    {
        LevelManager.Instance.RestartLevel();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetData()
    {
        PlayerData.SetUp();
        DataSaver.SaveData();
        resetText.SetActive(true);
    }
    
}
