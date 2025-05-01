using System;
using UnityEngine;

public class GHtZombie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Zombie"))
        {
            gameObject.SetActive(false);
        }
    }
}
