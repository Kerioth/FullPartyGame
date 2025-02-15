using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoTo(int scene) => SceneManager.LoadScene(scene);

    public void GoTo(string scene) => SceneManager.LoadScene(scene);

    public void Reload() => SceneManager.LoadScene(GetScene());

    public void NextScene() => SceneManager.LoadScene(GetScene() + 1);

    public int GetScene() => SceneManager.GetActiveScene().buildIndex;
}
