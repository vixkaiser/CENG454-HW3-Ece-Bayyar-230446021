using UnityEngine;

public class CoreDamageListener : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnCoreDamaged += HandleCoreDamage;
    }

    private void OnDisable()
    {
        GameEvents.OnCoreDamaged -= HandleCoreDamage;
    }

    private void HandleCoreDamage(int health)
    {
        Debug.Log("Observer Event Received. Current Health: " + health);
    }
}