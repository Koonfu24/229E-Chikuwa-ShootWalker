using UnityEngine;

public class Shoot : MonoBehaviour
{    [SerializeField] Transform ShootPoint;
    [SerializeField] GameObject target;
    [SerializeField] Rigidbody2D bulletPrefab;
    [SerializeField] float bulletSpeed;
    [SerializeField] float bulletforce;
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 5f, Color.red, 5f);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null)
            { 
                target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log("hit" + hit.collider.name);
                Vector2 projectileVelocity = CalculateProjectileVelocity(ShootPoint.position, hit.point, 1f);
                Rigidbody2D shootBullet = Instantiate(bulletPrefab, ShootPoint.position, Quaternion.identity);
                shootBullet.linearVelocity = projectileVelocity;
            }
        }
    }
    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;
        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0;
        Vector2 projectileVelocity = new Vector2(velocityX*bulletforce, velocityY*bulletSpeed);
        return projectileVelocity;

    }
}
