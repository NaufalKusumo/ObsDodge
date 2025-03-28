using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Handles player movement using WASD keys with smooth acceleration and deceleration in 3D space.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float acceleration = 10f;
    [SerializeField] private float deceleration = 10f;
    
    private Vector2 moveInput;
    private Vector3 currentVelocity;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component missing from player!");
            enabled = false;
            return;
        }
    }

    private void FixedUpdate()
    {
        // Convert 2D input to 3D movement
        Vector3 moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);
        
        // Calculate target velocity based on input
        Vector3 targetVelocity = moveDirection * moveSpeed;
        
        // Keep the current Y velocity (for gravity)
        targetVelocity.y = currentVelocity.y;
        
        // Smoothly interpolate current velocity towards target velocity
        if (moveInput != Vector2.zero)
        {
            // Accelerate
            currentVelocity = Vector3.MoveTowards(currentVelocity, targetVelocity, acceleration * Time.fixedDeltaTime);
        }
        else
        {
            // Decelerate
            currentVelocity = Vector3.MoveTowards(currentVelocity, new Vector3(0f, currentVelocity.y, 0f), deceleration * Time.fixedDeltaTime);
        }
        
        // Apply movement
        rb.linearVelocity = currentVelocity;
    }

    /// <summary>
    /// Called by the Input System when movement input is received.
    /// </summary>
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
} 