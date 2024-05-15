using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HW2Q3PlayerShoot : MonoBehaviour
{
    [SerializeField] HW2Bow bow;

    void OnFire(InputValue value)
    {
        if (!value.isPressed) return;
        bow.Shoot();
    }
}
