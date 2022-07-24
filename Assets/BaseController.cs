using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public abstract class BaseController<T> where T : BaseData
    {
        public abstract T Data { get; }

        public abstract void Inject();

    }
}
