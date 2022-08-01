using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service 
{
    List<IService> _serviceCollection = new List<IService>();
    public T Get<T>() where T : IService
    {
        T result = _serviceCollection.Find(T);
    }
}
