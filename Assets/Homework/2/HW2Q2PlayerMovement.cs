using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HW2Q2PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 3;
    Vector2 inputDir;

    #region Animation
    Animator animator;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void UpdateAnimator()
    {
        animator.SetBool("running", inputDir.sqrMagnitude > 0);
        bool flipX = (inputDir.x < 0 || (inputDir.x == 0 && transform.localScale.x < 0));
        transform.localScale = new(
            flipX ? -1 : 1,
            1,
            1
        );
    }
    #endregion

    void OnMove(InputValue v)
    {
        inputDir = v.Get<Vector2>();
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * (Vector3) inputDir;
        UpdateAnimator();
    }
}
