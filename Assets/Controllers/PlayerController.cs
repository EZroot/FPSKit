using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;
using CMF;

public class PlayerController : BaseController<PlayerData>
{
    [SerializeField]
    PlayerData _data;
    [SerializeField]
    AdvancedWalkerController _walkerController;
    [SerializeField]
    CameraTilt _cameraTilt;

    public override PlayerData Data { get => _data; set => _data = value; }

    public override void Initialization()
    {
        throw new System.NotImplementedException();
    }
}
