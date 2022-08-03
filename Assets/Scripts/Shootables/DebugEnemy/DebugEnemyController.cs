using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;

public class DebugEnemyController : BaseController<DebugEnemyData>
{
    [SerializeField]
    DebugEnemyData _data;
    public override DebugEnemyData Data { get => _data; set => _data = value; }

    public override void Initialization()
    {
        throw new System.NotImplementedException();
    }

    public void OnHit(DamageType damage)
    {
        transform.parent.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        Debug.Log($"{gameObject.name} recieved {damage.BaseDamage} * {damage.DamageMultiplier} with {damage.ACPierce} piercing!");

        float hitAmount = damage.BaseDamage * damage.DamageMultiplier + damage.ACPierce;
        Debug.Log($"{_data.HitPoints} hit for {hitAmount} damage!");
        _data.HitPoints -= hitAmount;
    }

}
