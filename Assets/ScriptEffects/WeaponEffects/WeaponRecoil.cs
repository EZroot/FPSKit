using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRecoil : MonoBehaviour
{
    Vector3 _currentPosition;
    Vector3 _startPosition;
    bool _isFiring = false;

    [SerializeField]
    Vector3 _targetPosition;
    [SerializeField]
    float _smoothAmount = 5;

    private void Start()
    {
        _startPosition = transform.localPosition;
        _currentPosition = _startPosition;
    }

    public void Fire()
    {
        _currentPosition = _targetPosition;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isFiring = true;
            Fire();
        }
    }

    private void LateUpdate()
    {
        // rotate 
        transform.localPosition = _currentPosition;
        if (_isFiring)
        {
            _currentPosition = Vector3.Slerp(transform.localPosition, _targetPosition, _smoothAmount * Time.deltaTime);
            if (_currentPosition.z > (_targetPosition.z - 0.01f) && _currentPosition.z < (_targetPosition.z + 0.01f))
            {
                _isFiring = false;
            }
        }
        else
        {
            _currentPosition = Vector3.Slerp(transform.localPosition, _startPosition, _smoothAmount * Time.deltaTime);
        }
    }
}
