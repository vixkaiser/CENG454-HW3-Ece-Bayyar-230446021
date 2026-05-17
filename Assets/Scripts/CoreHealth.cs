using UnityEngine;

public class CoreHealth : MonoBehaviour
{
    public int maxHealth = 100;

    private int currentHealth;
    private bool isDestroyed;
    public static bool gameOver;

    private void Start()
    {
        gameOver = false;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDestroyed)
            return;

        currentHealth -= damage;

        Debug.Log("Core Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDestroyed = true;
            gameOver = true;

            Debug.Log("GAME OVER");
        }
    }
}