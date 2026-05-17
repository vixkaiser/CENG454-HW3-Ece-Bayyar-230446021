using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = BulletPool.Instance.GetBullet();

    if (bullet == null)
        return;

        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.linearVelocity = firePoint.forward * bulletSpeed;
    }
}