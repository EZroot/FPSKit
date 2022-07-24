using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;


public class PlayerController : BaseController<PlayerData>
{
    [SerializeField]
    PlayerData _data;

    public override PlayerData Data => _data;

    public override void Inject()
    {
        throw new System.NotImplementedException();
    }
}
