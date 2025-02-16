using System;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPointChecker : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Debug.Log(hit.collider.name);
        if (hit.collider.TryGetComponent(out FinishPoint finish))
        {
            LevelManager.Instance.EndLevel();
            EndGame();
        }
    }

    private void OnEnable()
    {
        LevelManager.Instance.OnLevelStarted += ResetController;
        // LevelManager.Instance.OnLevelFinished += EndGame();
    }

    private void OnDisable()
    {
        LevelManager.Instance.OnLevelStarted -= ResetController;
        // LevelManager.Instance.OnLevelFinished -= EndGame();
    }

    void EndGame()
    {
        PlayerData.PlayerSpeed = GetComponent<ThirdPersonController>().MoveSpeed;
        GetComponent<ThirdPersonController>().MoveSpeed = 0;
        GetComponent<ThirdPersonController>().enabled = false;
    }

    void ResetController()
    {
        // print("Reset player: " + PlayerData.PlayerSpeed);
        GetComponent<ThirdPersonController>().enabled = true;
        GetComponent<ThirdPersonController>().MoveSpeed = PlayerData.PlayerSpeed;

    }

}
