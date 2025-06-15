using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHazard : MonoBehaviour
{
    public int health = 100;
    public Slider healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //healthBar.m = health;
        healthBar.value = health;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.value = health;

        if (health <= 0)
        {
            Debug.Log("Player Died!");
        }
    }
}

