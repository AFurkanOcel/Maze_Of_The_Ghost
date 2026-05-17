using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery_Control_Script : MonoBehaviour
{
    // Current battery life of the player
    public int playerBatteryLife = 3;

    // Maximum battery life the player can have
    public int maxBatteryLife = 3;

    // Time interval in seconds for draining the battery
    private float batteryDrainInterval = 20f;

    // UI element to display the battery progress
    public Image batteryProgressUI;

    // Reference to the flashlight GameObject
    public GameObject flashlight;

    private void Start()
    {
        // Start draining the battery over time
        StartCoroutine(DrainBattery());
    }

    private void Update()
    {
        // Enable or disable the flashlight based on battery life
        if (playerBatteryLife <= 0)
        {
            flashlight.SetActive(false);
        }
        else if (playerBatteryLife > 0)
        {
            flashlight.SetActive(true);
        }
    }

    private IEnumerator DrainBattery()
    {
        // Periodically reduce the player's battery life
        while (playerBatteryLife > 0)
        {
            yield return new WaitForSeconds(batteryDrainInterval);
            playerBatteryLife--; 
            // Update the UI to reflect the remaining battery level
            batteryProgressUI.fillAmount = (float)playerBatteryLife / (float)maxBatteryLife;
        }
    }
}
