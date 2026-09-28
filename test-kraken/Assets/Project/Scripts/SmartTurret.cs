using UnityEngine;

public class SmartTurret : MonoBehaviour
{
    public Transform player;
    public float visionRange = 6f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;
    public float timeBetweenShots = 1f;
    private float nextShotTime;


    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange);
        Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0f, 0f, angle);

            if (Time.time >= nextShotTime)
            {
                Shoot(direction);
                nextShotTime = Time.time + timeBetweenShots;
            }
        }
    }
    void Shoot(Vector2 direction)
    {
        if (bulletPrefab == null) return;

        Vector3 spawnPosition = firePoint != null ? firePoint.position : transform.position;

        GameObject bullet = Instantiate(bulletPrefab, spawnPosition, transform.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        if(rb != null)
        {
            rb.linearVelocity = direction * bulletSpeed;
        }

        Destroy(bullet, 3f);
    }

}
