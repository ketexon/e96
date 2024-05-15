using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    Vector2 lastMovementDirection = Vector2.zero;

    void OnMove(InputValue value)
    {
        lastMovementDirection = value.Get<Vector2>();
    }

    void Update()
    {
        transform.position += Time.deltaTime * speed * (Vector3) lastMovementDirection;
    }
}
