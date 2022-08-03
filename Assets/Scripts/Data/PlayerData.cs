using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;
using CMF;

public class PlayerData : BaseData
{
    [SerializeField]
    List<PickupableItem> _itemCollection = new List<PickupableItem>();

    public List<PickupableItem> ItemCollection { get => _itemCollection; set => _itemCollection = value; }

    [SerializeField]
    float _walkSpeed;
    [SerializeField]
    float _runSpeed;
    [SerializeField]
    float _cameraTiltDegree;
}
