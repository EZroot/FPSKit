using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;

public class ShootableData : BaseData
{
    [SerializeField]
    float _hitPoints;
    [SerializeField]
    float _acPoints;

    public float HitPoints { get => _hitPoints; set => _hitPoints = value; }
    public float AcPoints { get => _acPoints; set => _acPoints = value; }
}
