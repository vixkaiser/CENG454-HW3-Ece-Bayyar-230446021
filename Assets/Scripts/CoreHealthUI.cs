using TMPro;
using UnityEngine;

public class CoreHealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;

    private void OnEnable()
    {
        GameEvents.OnCoreDamaged += UpdateHealthText;
    }

    private void OnDisable()
    {
        GameEvents.OnCoreDamaged -= UpdateHealthText;
    }

    private void Start()
    {
        healthText.text = "Core: %100";
    }

    private void UpdateHealthText(int currentHealth)
    {
        healthText.text = "Core: %" + currentHealth;
    }
}