using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemy : MonoBehaviour
{
    public int maxHealth;
   
    int currentHealth;
   
    public int exp;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemy died!");
    }
}
