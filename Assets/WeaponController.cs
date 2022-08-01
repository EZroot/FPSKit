using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;

public class WeaponController : BaseController<WeaponData>
{
    [SerializeField]
    WeaponData _data;
    public override WeaponData Data { get => _data; set => _data=value; }

    public override void Initialization()
    {
        throw new System.NotImplementedException();
    }
}
