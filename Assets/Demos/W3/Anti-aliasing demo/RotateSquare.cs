using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace W3AntiAliasingDemo
{
    public class RotateSquare : MonoBehaviour
    {
        [SerializeField] float speed;

        void Update()
        {
            transform.rotation *= Quaternion.Euler(0, 0, Time.deltaTime * speed);
        }
    }

}