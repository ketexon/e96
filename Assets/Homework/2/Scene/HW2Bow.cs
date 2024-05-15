using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2Bow : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] HW2Q4SFXManager sfxManager;
    [SerializeField] GameObject arrow;

    void Reset()
    {
        animator = GetComponent<Animator>();
    }

    public void Shoot()
    {
        animator.SetTrigger("shoot");
        sfxManager.PlayBowShootSound();
    }

    public void OnShootAnimationCompleted()
    {
        Instantiate(
            arrow,
            transform.position,
            transform.lossyScale.x < 0
                ? Quaternion.Euler(0, 0, 180)
                : Quaternion.identity
        );
    }
}
