using FPSKit;
using System;
using System.Threading.Tasks;

public abstract class BaseInfoLoader<T> where T : BaseData
{
    public abstract Action<T> OnSaveData { get; set; }
    public abstract Action<T> OnLoadData { get; set; }
    public abstract Task<T> SaveData(T data);
    public abstract Task<T> LoadData();
}
