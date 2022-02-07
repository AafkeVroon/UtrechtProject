using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public PlayerSettings playerSettings;

    public CharacterController controller;

    public Transform groundCheck;

    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, playerSettings.groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * playerSettings.speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(playerSettings.jumpHeight * -2f * playerSettings.gravity);
        }

        velocity.y += playerSettings.gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
