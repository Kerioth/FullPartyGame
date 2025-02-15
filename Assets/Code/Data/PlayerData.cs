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

    public static void SetUp()
    {
        PlayerSpeed = 5;
        data = new AllData();
        data.playerLevels = new List<LevelData>();
        data.playerLevels.Add(new LevelData(0, 0));
        data.playerLevels.Add(new LevelData(1, 0));
        data.playerLevels.Add(new LevelData(2, 0));
        data.playerLevels.Add(new LevelData(3, 0));
        data.playerLevels.Add(new LevelData(4, 0));
        data.playerLevels.Add(new LevelData(5, 0));
    }

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

    public LevelData(int index, int stars)
    {
        this.index = index;
        this.stars = stars;
    }
}