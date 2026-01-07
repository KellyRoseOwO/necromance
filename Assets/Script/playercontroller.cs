using UnityEngine;

public class Controller : MonoBehaviour
{
    // Rigidbody for physics (optional if you want physics-based movement)
    private Rigidbody m_Rigidbody;

    // Movement speed and rotation speed
    public float m_Speed = 0.1f;
    public float m_RotateSpeed = 50.0f;

    // Reference to the Animator component on your GLB model
    public Animator animator;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bool isMoving = false;

        // Move forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * m_Speed;
            isMoving = true;
        }

        // Move backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * m_Speed * 0.5f;
            isMoving = true;
        }

        // Rotate right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * m_RotateSpeed, Space.World);
        }

        // Rotate left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * m_RotateSpeed, Space.World);
        }

        // Update Animator parameter
        if (animator != null)
        {
            animator.SetBool("IsWalking", isMoving);
        }
    }
}
