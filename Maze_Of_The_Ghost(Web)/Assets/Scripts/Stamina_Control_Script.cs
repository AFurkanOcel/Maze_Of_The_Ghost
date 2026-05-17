using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina_Control_Script : MonoBehaviour
{
    // Player's current stamina and maximum stamina values
    public float playerStamina = 100f;
    [SerializeField]
    private float maxStamina = 100f;
    public bool staminaRegenerated = true; // Whether stamina is regenerating
    public bool playerIsSprinting = false; // Whether the player is sprinting

    // Player movement speeds for walking and sprinting
    public float walkSpeed = 1.5f;
    public float sprintSpeed = 3f; 

    // Stamina consumption and regeneration rates
    [SerializeField] private float staminaDrain = 0.5f; 
    [SerializeField] private float staminaRegen = 0.5f;

    // UI element for showing stamina progress
    public Image staminaProgressUI;

    // Sound played when stamina runs out and breathing intensifies
    public AudioSource breathingSound;

    // Reference to the Move_Player_Script for controlling player speed
    private Move_Player_Script movePlayerScript;

   
    void Start()
    {
        // Initializes player movement reference.
        movePlayerScript = GetComponent<Move_Player_Script>();
    }

    void Update()
    {
        // Handles stamina regeneration and updates the stamina UI.
        if (!playerIsSprinting)
        {
            RegenerateStamina();
        }
        UpdateStaminaBar();
    }

    private void RegenerateStamina()
    {
        // Regenerates stamina when it is not at the maximum.
        if (playerStamina < maxStamina)
        {
            playerStamina += staminaRegen * Time.deltaTime;
            playerStamina = Mathf.Clamp(playerStamina, 0, maxStamina);
        }
    }

    public void Sprint()
    {
        // Handles stamina drain and speed increase while sprinting.
        playerIsSprinting = true;
        playerStamina -= staminaDrain * Time.deltaTime;
        playerStamina = Mathf.Clamp(playerStamina, 0, maxStamina);

        movePlayerScript.speed = sprintSpeed;

        if (playerStamina <= 0)
        {
            StopSprinting();
            breathingSound.Play();
        }
    }

    public bool CanSprint()
    {
        // Checks if there is enough stamina to sprint.
        return playerStamina > 0;
    }

    public void StopSprinting()
    {
        // Resets sprinting state and restores normal walking speed.
        playerIsSprinting = false;
        movePlayerScript.speed = walkSpeed;
    }

    private void UpdateStaminaBar()
    {
        // Updates the stamina UI to reflect the current stamina value.
        if (staminaProgressUI != null)
        {
            staminaProgressUI.fillAmount = playerStamina / maxStamina;
        }
    }
}
