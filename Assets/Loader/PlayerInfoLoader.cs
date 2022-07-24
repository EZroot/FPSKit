using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerInfoLoader : BaseInfoLoader<PlayerData>
{
    public string FILE_LOCATION = Application.dataPath + "/playerdata.json";

    public override Action<PlayerData> OnSaveData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Action<PlayerData> OnLoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override async Task<PlayerData> LoadData()
    {
        PlayerData result;
        string data;
        if (File.Exists(FILE_LOCATION))
        {
            using (StreamReader sr = new StreamReader(FILE_LOCATION))
            {
                data = await sr.ReadToEndAsync();
            }
            result = (PlayerData)(JsonUtility.FromJson(data, typeof(PlayerData)));
            OnLoadData(result);
            return result;
        }
        Debug.LogError("Failed to get PlayerData.json at "+FILE_LOCATION);
        return null;
    }

    public override async Task<PlayerData> SaveData(PlayerData data)
    {
        using (StreamWriter sw = new StreamWriter(FILE_LOCATION))
        {
            await sw.WriteAsync(JsonUtility.ToJson(data));
        }
        OnSaveData(data);
        return data;
    }
}
