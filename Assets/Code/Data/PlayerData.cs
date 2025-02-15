using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class PlayerData
{
    public static AllData data;

    public static int Level;
    public static void SetLevel(int level)
    {
        Level = level;
        data.level = level;
    }

    public static float PlayerSpeed = 5;

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