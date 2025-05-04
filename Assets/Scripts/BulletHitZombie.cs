using System;
using UnityEngine;

public class BulletHitZombie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
           Destroy(other.gameObject); 
           Destroy(gameObject);
        }
    }
}
