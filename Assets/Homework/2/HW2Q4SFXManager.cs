using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2Q4SFXManager : MonoBehaviour
{
    [SerializeField] AudioSource bowShootSource;
    [SerializeField] AudioSource footstepSource;

    void Awake()
    {
        bowShootSource = GetComponent<AudioSource>();
    }

    public void PlayBowShootSound()
    {
        bowShootSource.Play();
    }

    public void PlayFootstepSound()
    {
        footstepSource.Play();
    }
}
