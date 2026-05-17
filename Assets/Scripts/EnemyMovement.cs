using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("Core").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Core"))
        {
            CoreHealth coreHealth = collision.gameObject.GetComponent<CoreHealth>();

            if (coreHealth != null)
            {
                coreHealth.TakeDamage(5);
            }

            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized;

        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}