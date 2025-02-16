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

    private void OnBecameInvisible()
    {
        resetText.SetActive(false);
    }

    public void ToggleMusic(bool isOn)
    {
        
        AudioBox.Instance.MusicMute(isOn);
        AudioBox.Instance.Play("Tap");
    }
    
    public void ToggleSounds(bool isOn)
    {
        AudioBox.Instance.SoundSwitch(isOn);
        AudioBox.Instance.Play("Tap");
    }

    public void RestartGame()
    {
        AudioBox.Instance.Play("Tap");
        LevelManager.Instance.RestartLevel();
    }

    public void GoToMenu()
    {
        AudioBox.Instance.Play("Tap");
        SceneManager.LoadScene(0);
    }

    public void ResetData()
    {
        AudioBox.Instance.Play("Tap");
        PlayerData.SetUp();
        DataSaver.SaveData();
        resetText.SetActive(true);
    }
    
}
