using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    private Transform target;

    private void Start()
    {
        target = GameObject.Find("Core").transform;
    }

    private void Update()
    {
        if (target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized;

        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}