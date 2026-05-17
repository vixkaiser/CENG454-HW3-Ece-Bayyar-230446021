using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float lifeTime = 3f;

    private void OnEnable()
    {
        Invoke(nameof(DisableBullet), lifeTime);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        DisableBullet();
    }

    private void DisableBullet()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        gameObject.SetActive(false);
    }
}