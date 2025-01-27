using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move_Player_Script : MonoBehaviour
{
    public Stamina_Control_Script staminaControlScript; // Manages stamina during sprinting
    public float speed = 1.5f; // Base movement speed
    private float acceleration = 10f; // Acceleration rate
    private float deceleration = 10f; // Deceleration rate

    Rigidbody rb;
    Vector3 movedirection;
    public Vector3 currentVelocity;
    public Transform orientation;

    public LayerMask groundMask; // Used for ground detection
    public float playerHeight; // Player height for raycast
    public float groundDrag; // Drag applied when grounded
    bool grounded;

    void Start()
    {
        // Initial setup for stamina control, cursor, and Rigidbody
        staminaControlScript = GetComponent<Stamina_Control_Script>();
        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    public void OnApplicationFocus()
    {
        // Handles cursor visibility and locking on focus changes
        if (Input.GetKeyDown(KeyCode.Escape)) Cursor.visible = true;
        if (Input.GetMouseButtonDown(0)) Cursor.visible = false;
    }

    private void Update()
    {
        // Handles ground checks, speed control, drag, and sprint input
        // OnApplicationFocus();
        CheckGround();
        ControlSpeed();
        HandleSprintInput();
        ApplyGroundDrag();
    }

    private void FixedUpdate()
    {
        // Handles player movement logic
        Player_Movement();
    }

    private void ApplyGroundDrag()
    {
        // Applies appropriate drag based on whether the player is grounded
        rb.drag = grounded ? groundDrag : 0;
    }

    private void CheckGround()
    {
        // Checks if the player is on the ground using a raycast
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, groundMask);
        if (grounded && rb.velocity.y < 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        }
    }

    public void Player_Movement()
    {
        // Handles player movement, including acceleration, deceleration, and velocity updates
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        bool playerIsWalking = !Input.GetKey(KeyCode.LeftShift);
        if (playerIsWalking)
        {
            staminaControlScript.playerIsSprinting = false;
        }
        else if (!playerIsWalking && currentVelocity.sqrMagnitude > 0)
        {
            if (staminaControlScript.playerStamina > 0)
            {
                staminaControlScript.playerIsSprinting = true;
                staminaControlScript.Sprint();
            }
            else
            {
                playerIsWalking = true;
            }
        }

        movedirection = orientation.forward * vertical + orientation.right * horizontal;

        currentVelocity = movedirection != Vector3.zero
            ? Vector3.MoveTowards(currentVelocity, movedirection * speed, acceleration * Time.fixedDeltaTime)
            : Vector3.MoveTowards(currentVelocity, Vector3.zero, deceleration * Time.fixedDeltaTime);

        rb.velocity = new Vector3(currentVelocity.x, rb.velocity.y, currentVelocity.z);
    }

    private void ControlSpeed()
    {
        // Limits the player's speed to the defined maximum
        Vector3 flatvel = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        if (flatvel.magnitude > speed)
        {
            Vector3 limitedvel = flatvel.normalized * speed;
            rb.velocity = new Vector3(limitedvel.x, rb.velocity.y, limitedvel.z);
        }
    }

    private void HandleSprintInput()
    {
        // Manages sprint input and updates stamina accordingly
        if (Input.GetKey(KeyCode.LeftShift) && staminaControlScript.CanSprint())
        {
            staminaControlScript.Sprint();
        }
        else
        {
            staminaControlScript.StopSprinting();
        }
    }
}
