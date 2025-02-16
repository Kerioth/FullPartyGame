using UnityEngine;

public class LevelPrefab : MonoBehaviour
{
    [SerializeField] private Transform playerStartPoint;
    [SerializeField] private Transform playerEndPoint;
    public void SetUp()
    {
        // var player = FindFirstObjectByType<PlayerPrefab>();
        // var player = LevelManager.Instance.playerPrefab;
        var player = FindFirstObjectByType<PlayerPrefab>();
        player.transform.position = playerStartPoint.position;
        
        playerEndPoint.gameObject.SetActive(true);
    }

}
