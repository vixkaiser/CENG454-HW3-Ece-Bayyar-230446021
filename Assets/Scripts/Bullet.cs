using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float lifeTime = 3f;

    private void OnEnable()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        Invoke(nameof(DisableBullet), lifeTime);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            DisableBullet();
        }
    }

    private void DisableBullet()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        gameObject.SetActive(false);
    }
}