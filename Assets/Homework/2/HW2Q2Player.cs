using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2Q2Player : MonoBehaviour
{
    int maxPlayerHealth;
    int playerHealth;

    public void TakeDamage(int damage)
    {
        playerHealth = Math.Max(playerHealth - damage, 0);
    }

    public void Heal(int health)
    {
        playerHealth = Math.Min(playerHealth + health, maxPlayerHealth);
    }
}
