using UnityEngine;

public class TripleShotStrategy : IWeaponStrategy
{
    public void Shoot(Transform firePoint)
    {
        ShootBullet(firePoint, 0);
        ShootBullet(firePoint, -45);
        ShootBullet(firePoint, 45);
    }

    private void ShootBullet(Transform firePoint, float angle)
    {
        GameObject bullet = BulletPool.Instance.GetBullet();

        if (bullet == null)
            return;

        bullet.transform.position = firePoint.position;

        Quaternion rotation = firePoint.rotation * Quaternion.Euler(0, angle, 0);

        bullet.transform.rotation = rotation;

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.linearVelocity = rotation * Vector3.forward * 20f;
    }
}