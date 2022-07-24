using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;


public class PlayerController : BaseController<PlayerData>
{
    [SerializeField]
    PlayerData _data;

    public override PlayerData Data { get => _data; set => _data = value; }

    public override void Initialization()
    {
        throw new System.NotImplementedException();
    }
}
