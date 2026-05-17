using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public Transform firePoint;

    private IWeaponStrategy currentStrategy;

    private void Start()
    {
        currentStrategy = new SingleShotStrategy();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentStrategy.Shoot(firePoint);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentStrategy = new SingleShotStrategy();

            Debug.Log("Single Shot");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            currentStrategy = new TripleShotStrategy();

            Debug.Log("Triple Shot");
        }
    }
}