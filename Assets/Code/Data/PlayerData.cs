using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class PlayerData
{
    public static AllData data;
    
    public static int Level
    {
        get => data.level;
        set => data.level = value;
    }

    public static float PlayerSpeed;

}

[System.Serializable]
public class AllData
{
    public int level;

    public List<LevelData> playerLevels;
}

[System.Serializable]
public class LevelData
{
    public int index;
    public int stars;
}