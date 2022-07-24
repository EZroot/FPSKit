using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public interface IBaseController<T> where T : BaseData
    {
        public abstract T Data { get; set; }

        public abstract void Initialization();
    }
}