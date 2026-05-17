using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float survivalTime = 120f;

    public static bool missionComplete;

    private void Update()
    {
        if (CoreHealth.gameOver || missionComplete)
            return;

        survivalTime -= Time.deltaTime;

        if (survivalTime <= 0f)
        {
            missionComplete = true;

            Debug.Log("MISSION COMPLETE");
        }
    }
}