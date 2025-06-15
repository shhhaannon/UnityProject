using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damage = 10;              // Amount of damage per hit
    public float damageRate = 1f;        // Time between damage ticks
    private float nextDamageTime = 0f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Time.time >= nextDamageTime)
        {
            PlayerController player = other.GetComponent<PlayerController>();
            player.TakeDamage(damage * Time.deltaTime);
            nextDamageTime = Time.time + damageRate;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nextDamageTime = 0f; // reset when player leaves
        }
    }
}
