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

    public Dialogue dialogue;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Debug.Log(dialogue.isPlayerInDialogue());


        bool isInDialogue = dialogue.isPlayerInDialogue();
        bool isMoving = false;

        // Move forward
        if (Input.GetKey(KeyCode.W) && !isInDialogue)
        {
            transform.position += transform.forward * m_Speed;
            isMoving = true;
        }

        // Move backward
        if (Input.GetKey(KeyCode.S) && !isInDialogue)
        {
            transform.position -= transform.forward * m_Speed * 0.5f;
            isMoving = true;
        }

        // Rotate right
        if (Input.GetKey(KeyCode.D) && !isInDialogue)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * m_RotateSpeed, Space.World);
        }

        // Rotate left
        if (Input.GetKey(KeyCode.A) && !isInDialogue)
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
