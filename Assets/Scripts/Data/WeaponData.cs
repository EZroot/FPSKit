using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class WeaponData : BaseData
    {
        [Range(0f, 999f)]
        [SerializeField]
        float _outputDamage;
        [Range(0f, 1f)]
        [SerializeField]
        float _fireRate;
        [Range(0f,1f)]
        [SerializeField]
        float _recoilStrength;
    }
}