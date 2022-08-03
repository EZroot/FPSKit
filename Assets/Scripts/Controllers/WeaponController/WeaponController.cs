using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPSKit;

public class WeaponController : BaseController<WeaponData>
{
    [SerializeField]
    LayerMask _shootableLayer;

    [SerializeField]
    Camera _mainCamera;

    [SerializeField]
    WeaponData _data;
    public override WeaponData Data { get => _data; set => _data=value; }

    public override void Initialization()
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f, _shootableLayer.value))
            {
                hit.collider.gameObject.GetComponent<ShootableReceiver>().Hit(new DamageType { ACPierce = 3, BaseDamage = Random.Range(8,12), DamageMultiplier = 1.2f });
            }
        }
    }
}
