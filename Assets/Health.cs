using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // in binding of isacc you start with 3 full hearts with 2 half hearts each so you can take 2 damage for each 1 full heart
    // each health slot is 2 health (2 half hearts)
    private int maxHealthSlots = 40; // (20) containers of (x 2) hp
    public int startingHealthSlots = 6; // 3 containers
    public int startingHealth; // depends on character

    private int currentHealthSlots;
    private int currentHealth;

    public void Start()
    {
        startingHealth = 6; // 3 x 2    (for isaac) & more
        currentHealth = startingHealth;
    }

    public void Heal(int hp)
    {
        if (hp + startingHealth > startingHealthSlots)
        {
            startingHealth = startingHealthSlots;
        }
    }

    public void IncreaseHealth(int health)
    {
        // for each 2 health you get 1 container
        // CANNOT GET ODD NUMBERS OF HEALTH HERE
        if (health % 2 == 1)
        {
            //DO NOT ADD
            return;
        }
        else if (currentHealthSlots + health > maxHealthSlots)
        {
            currentHealthSlots = maxHealthSlots;
        }
        else
        {
            currentHealthSlots += health;
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth - damage < 0)
        {
            //DIE
        }
        else
        {
            currentHealth -= damage;
        }
    }
}
