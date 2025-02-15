using UnityEngine;

public static class DataSaver
{
    public static void SaveData()
    {
        PlayerPrefs.SetString("data", JsonUtility.ToJson(PlayerData.data));
        PlayerPrefs.Save();
    }

    public static void LoadData()
    {
        string json = PlayerPrefs.GetString("data");
        PlayerData.data = JsonUtility.FromJson<AllData>(json);
    }
}
