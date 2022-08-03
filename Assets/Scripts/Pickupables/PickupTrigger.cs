using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTrigger : MonoBehaviour
{
    [SerializeField]
    PlayerData _playerData;

    [SerializeField]
    LayerMask _pickupLayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == (other.gameObject.layer| (1 << _pickupLayer)))
        {
            PickupableItem item = other.GetComponent<PickupableItem>();
            item.OnPickup();
            _playerData.ItemCollection.Add(item);
        }
    }

}
