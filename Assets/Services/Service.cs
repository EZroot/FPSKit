using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service 
{
    List<IService> _serviceCollection = new List<IService>();
    public T Get<T>() where T : IService
    {
        T result = null;// = _serviceCollection.Find(T);
        return result;
    }
}
