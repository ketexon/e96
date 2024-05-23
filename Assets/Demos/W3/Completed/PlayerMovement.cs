using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEngine;
using UnityEngine.InputSystem;

namespace W3
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Fields
        [SerializeField] float vel = 3;
        [SerializeField] float jumpVel = 5;
        [SerializeField] LayerMask groundLayerMask;
        #endregion

        [SerializeField] Animator animator;
        [SerializeField] SpriteRenderer spriteRenderer;

        Rigidbody2D rb;

        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void OnMove(InputValue inputValue)
        {
            Vector2 value = inputValue.Get<Vector2>();
            rb.velocity = new(value.x * vel, rb.velocity.y);

            animator.SetBool("running", !Mathf.Approximately(value.x, 0));
            if(!Mathf.Approximately(value.x, 0))
            {
                spriteRenderer.flipX = value.x < 0;
            }

            if (value.y > 0)
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, .55f, groundLayerMask);
                Debug.Log(hit.collider);
                if (hit)
                {
                    rb.velocity = new(rb.velocity.x, jumpVel);
                }
            }
        }
    }
}
