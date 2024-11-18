using System;
using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private WeaponBike _bikeWeapon;
    private bool _isWeaponDecorated;
    void Start()
    {
        _bikeWeapon = (WeaponBike)FindObjectOfType(typeof(WeaponBike));
    }
    void OnGUI()
    {
        if (!_isWeaponDecorated)
            if (GUILayout.Button("Decorate Weapon"))
            {
                _bikeWeapon.Decorate();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        if (_isWeaponDecorated)
            if (GUILayout.Button("Reset Weapon"))
            {
                _bikeWeapon.Reset();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        if (GUILayout.Button("Toggle Fire"))
            _bikeWeapon.ToggleFire();
    }
}
