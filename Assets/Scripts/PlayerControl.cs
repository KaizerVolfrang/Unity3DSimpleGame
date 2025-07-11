using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float movementSpeed = 1;
    Rigidbody rb;
    public float jumpForce = 5.0f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;
    GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GetComponent<GameManager>();
    }
    void Update()
    {
        if (gameManager.healthPlayer <= 0)
        {
            return;
        }
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer, QueryTriggerInteraction.Ignore);
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * movementSpeed;
        move = Vector3.ClampMagnitude(move, movementSpeed);

        if (move != Vector3.zero)
        {
            rb.MovePosition(transform.position + move * Time.deltaTime);
            rb.MoveRotation(Quaternion.LookRotation(move));
        }

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
