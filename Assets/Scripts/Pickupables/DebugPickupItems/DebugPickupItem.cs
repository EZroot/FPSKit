using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPickupItem : PickupableItem
{
    [SerializeField]
    RarityType _rarity;

    public override RarityType Rarity { get => _rarity; }

    public override void OnDrop(Vector3 position)
    {
        gameObject.SetActive(true);
        Debug.Log("Dropped item! " + _rarity.ToString());
    }

    public override void OnPickup()
    {
        gameObject.SetActive(false);
        Debug.Log("Picked up item! " + _rarity.ToString());
    }
}
