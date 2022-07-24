using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInfoLoader : BaseInfoLoader<GameData>
{
    public override Action<GameData> OnSaveData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override Action<GameData> OnLoadData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override GameData LoadData()
    {
        throw new NotImplementedException();
    }

    public override GameData SaveData()
    {
        throw new NotImplementedException();
    }
}
