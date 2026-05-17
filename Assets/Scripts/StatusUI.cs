using TMPro;
using UnityEngine;

public class StatusUI : MonoBehaviour
{
    public static StatusUI Instance;

    public TextMeshProUGUI weaponModeText;
    public TextMeshProUGUI rapidFireText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        weaponModeText.text = "Weapon Mode: Single Shot";
        rapidFireText.text = "";
    }

    public void SetWeaponMode(string message)
    {
        weaponModeText.text = message;
    }

    public void SetRapidFireStatus(string message)
    {
        rapidFireText.text = message;
    }

    public void ClearRapidFireStatus()
    {
        rapidFireText.text = "";
    }

    public void ShowTemporaryRapidFireStatus(string message, float duration)
    {
        StopAllCoroutines();

        StartCoroutine(ClearStatusAfterDelay(message, duration));
    }

    private System.Collections.IEnumerator ClearStatusAfterDelay(string message, float duration)
    {
        rapidFireText.text = message;

        yield return new WaitForSeconds(duration);

        rapidFireText.text = "";
    }
}