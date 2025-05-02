using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public GameObject target;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(target);
        }
    }
}
