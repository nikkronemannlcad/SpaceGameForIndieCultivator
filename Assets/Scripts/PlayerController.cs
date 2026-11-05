using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [SerializeField] private float speed = 5;
    [SerializeField] private float jumpHeight = 1.5f;
    [SerializeField] float gravity = -10f;

    private float jumpVelocity;
    private Vector3 movement;
    private bool jumpPressed;
    private int testCounter = 0;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpPressed = true;
            testCounter++;
            Debug.Log("Jump Pressed: " + testCounter + "Times");
        }
    }
    private void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(movement.x, 0, movement.y).normalized;
        
        if (jumpPressed && characterController.isGrounded) {
            jumpVelocity = Mathf.Sqrt(jumpHeight * -gravity);
        }
        jumpPressed = false;

        jumpVelocity += gravity * Time.deltaTime;

        Vector3 velocity = move * speed;
        velocity.y = jumpVelocity;
        characterController.Move(velocity * Time.deltaTime);

        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }
    }
}
