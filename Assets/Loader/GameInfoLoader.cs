using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace FPSKit
{
    public class GameInfoLoader : BaseInfoLoader<GameData>
    {
        public string FILE_LOCATION = Application.dataPath + "/gamedata.json";

        public override Action<GameData> OnSaveData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Action<GameData> OnLoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override async Task<GameData> LoadData()
        {
            GameData result;
            string data;
            if (File.Exists(FILE_LOCATION))
            {
                using (StreamReader sr = new StreamReader(FILE_LOCATION))
                {
                    data = await sr.ReadToEndAsync();
                }
                result = (GameData)(JsonUtility.FromJson(data, typeof(GameData)));
                OnLoadData(result);
                return result;
            }
            Debug.LogError("Failed to get PlayerData.json at " + FILE_LOCATION);
            return null;
        }

        public override async Task<GameData> SaveData(GameData data)
        {
            using (StreamWriter sw = new StreamWriter(FILE_LOCATION))
            {
                await sw.WriteAsync(JsonUtility.ToJson(data));
            }
            OnSaveData(data);
            return data;
        }
    }
}