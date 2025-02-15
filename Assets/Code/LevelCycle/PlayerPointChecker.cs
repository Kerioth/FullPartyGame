using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPointChecker : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Finish"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GetComponent<ThirdPersonController>().MoveSpeed = 0;
        GetComponent<ThirdPersonController>().enabled = false;
        GetComponent<StarterAssetsInputs>().cursorLocked = false;
        // GetComponent<PlayerInput>().
        LevelManager.Instance.EndLevel();
        Cursor.lockState = CursorLockMode.None;
    }
    
}
