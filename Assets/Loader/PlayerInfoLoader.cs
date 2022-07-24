using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerInfoLoader : BaseInfoLoader<PlayerData>
{
    public string FILE_LOCATION = Application.dataPath + "/playerdata.json";

    public override Action<PlayerData> OnSaveData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Action<PlayerData> OnLoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override PlayerData LoadData()
    {
        if (File.Exists(FILE_LOCATION))
        {
            var data = (PlayerData)(JsonUtility.FromJson(File.ReadAllText(FILE_LOCATION), typeof(PlayerData)));
            OnLoadData(data);
            return data;
        }
        Debug.LogError("Failed to get PlayerData.json at "+FILE_LOCATION);
        return null;
    }

    public override PlayerData SaveData(PlayerData data)
    {
        File.WriteAllText(FILE_LOCATION, JsonUtility.ToJson(data));
        OnSaveData(data);
        return data;
    }
}
