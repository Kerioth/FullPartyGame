using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
   public static int level;

   public static List<LevelData> playerLevels;
}

[System.Serializable]
public class LevelData
{
    public int index;
    public int stars;
}