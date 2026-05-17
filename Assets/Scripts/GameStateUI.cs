using TMPro;
using UnityEngine;

public class GameStateUI : MonoBehaviour
{
    public TextMeshProUGUI gameStateText;

    private void Update()
    {
        if (CoreHealth.gameOver)
        {
            gameStateText.text = "GAME OVER";
        }
        else if (GameManager.missionComplete)
        {
            gameStateText.text = "MISSION COMPLETE";
        }
    }
}