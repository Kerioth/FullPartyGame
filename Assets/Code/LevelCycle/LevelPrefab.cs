using UnityEngine;

public class LevelPrefab : MonoBehaviour
{
    [SerializeField] private Transform playerStartPoint;
    [SerializeField] private Transform playerEndPoint;
    public void SetUp()
    {
        var player = FindFirstObjectByType<PlayerPrefab>();
        player.transform.position = playerStartPoint.position;
    }

}
