using System;
using Unity.VisualScripting;
using UnityEngine;

public class Hit : MonoBehaviour
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
