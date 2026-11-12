using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [SerializeField] private float speed = 5;
    [SerializeField] private float jumpHeight = 1.5f;
    [SerializeField] float gravity = -10f;
    [SerializeField] private float mouseSense = 100f;
    private float jumpVelocity;
    private Vector3 movement;
    private bool jumpPressed;

    //player health script for damage
    public PlayerHealthScript phs;


    //Gonna Start Testing changing the angle for movement (Hansen please make the gun shoot based on which direction character is facing)
    //Most likely going to need to nerf strafing and back strafing because movement is a little cooked
    //(I might fix but if one of you guys is interested in attempting go for it on your own branch).
    //-Nik

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpPressed = true;
        }
    }
    private void FixedUpdate()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);

        Vector3 move = new Vector3(movement.x, 0, movement.y).normalized;
        move = transform.TransformDirection(move);
        
        if (jumpPressed && characterController.isGrounded) {
            jumpVelocity = Mathf.Sqrt(jumpHeight * -gravity);
        }
        jumpPressed = false;

        jumpVelocity += gravity * Time.deltaTime;

        Vector3 velocity = move * speed;
        velocity.y = jumpVelocity;
        characterController.Move(velocity * Time.deltaTime);
    }

    //hi its me aurora again hijacking your script
    //dropping how the player takes damagage here and referencing the player health script hereee

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            phs.TakeDamage(1);
        }
    }
}
