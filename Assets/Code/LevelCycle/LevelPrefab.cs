using UnityEngine;

public class LevelPrefab : MonoBehaviour
{
    [SerializeField] private Transform playerStartPoint;
    [SerializeField] private GameObject playerEndPoint;

    public void SetUp(Transform player)
    {
        playerEndPoint.SetActive(false);
        // var player = FindFirstObjectByType<PlayerPrefab>();
        // var player = LevelManager.Instance.playerPrefab;
        player.position = playerStartPoint.position;
        playerEndPoint.SetActive(true);
    }

}
