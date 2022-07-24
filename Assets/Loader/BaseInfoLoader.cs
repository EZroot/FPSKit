using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;
using System;

public abstract class BaseInfoLoader<T> where T : BaseData
{
    public abstract Action<T> OnSaveData { get; set; }
    public abstract Action<T> OnLoadData { get; set; }
    public abstract T SaveData(T data);
    public abstract T LoadData();
}
