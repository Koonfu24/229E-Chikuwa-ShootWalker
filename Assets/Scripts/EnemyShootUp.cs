using UnityEngine;

public class EnemyShootUp : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float shootInterbal = 3f;
    void Start()
    {
        InvokeRepeating(nameof(ShootBullet), 0f, shootInterbal);

    }
    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * bulletSpeed;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
