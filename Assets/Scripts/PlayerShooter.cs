using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public Transform firePoint;

    private IWeaponStrategy currentStrategy;
    private IFireRate currentFireRate;

    private float fireTimer;

    private bool rapidFireActive;

    private float rapidFireDuration = 5f;
    private float rapidFireCooldown = 60f;

    private float rapidFireEndTime;
    private float nextRapidFireTime;

    private void Start()
    {
        currentStrategy = new SingleShotStrategy();

        currentFireRate = new NormalFireRate();
    }

    private void ActivateRapidFire()
    {
        if (Time.time < nextRapidFireTime)
        {
            Debug.Log("Rapid Fire is on cooldown");

            return;
        }

        rapidFireActive = true;

        rapidFireEndTime = Time.time + rapidFireDuration;

        nextRapidFireTime = Time.time + rapidFireCooldown;

        currentFireRate = new RapidFireDecorator(new NormalFireRate());

        Debug.Log("Rapid Fire Activated");
    }

    private void LateUpdate()
    {
        if (rapidFireActive && Time.time >= rapidFireEndTime)
        {
            rapidFireActive = false;

            currentFireRate = new NormalFireRate();

            Debug.Log("Rapid Fire Ended");
        }
    }

    private void Update()
    {
        fireTimer += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (fireTimer >= currentFireRate.GetFireRate())
            {
                currentStrategy.Shoot(firePoint);

                fireTimer = 0f;
            }
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateRapidFire();
        }
    }
}