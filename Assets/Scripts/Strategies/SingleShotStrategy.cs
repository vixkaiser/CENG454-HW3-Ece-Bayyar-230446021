using UnityEngine;

public class SingleShotStrategy : IWeaponStrategy
{
    public void Shoot(Transform firePoint)
    {
        GameObject bullet = BulletPool.Instance.GetBullet();

        if (bullet == null)
            return;

        bullet.transform.position = firePoint.position;
        bullet.transform.rotation = firePoint.rotation;

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.linearVelocity = firePoint.forward * 20f;
    }
}