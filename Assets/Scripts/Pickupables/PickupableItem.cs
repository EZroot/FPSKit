using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupableItem : MonoBehaviour
{
    public enum RarityType
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythic
    }

    public abstract void OnPickup();
    public abstract void OnDrop(Vector3 position);
    public abstract RarityType Rarity { get; }
}
