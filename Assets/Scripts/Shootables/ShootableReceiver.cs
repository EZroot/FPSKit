using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootableReceiver : MonoBehaviour
{
    public UnityEvent<DamageType> OnHitRecieved;

    public void Hit(DamageType damage)
    {
        OnHitRecieved.Invoke(damage);
    }
}

public struct DamageType
{
    public float BaseDamage;
    public float DamageMultiplier;
    public float ACPierce;
}