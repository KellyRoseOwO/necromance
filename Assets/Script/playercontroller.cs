using GLTFast.Schema;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Rigidbody for physics (optional if you want physics-based movement)
    private Rigidbody m_Rigidbody;

    // Movement speed and rotation speed
    public float m_Speed = 5f;
    public float m_RotateSpeed = 50.0f;

    // Reference to the Animator component on your GLB model
    public Animator animator;

    public Dialogue dialogue;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Debug.Log(dialogue.isPlayerInDialogue());

        bool isInDialogue = dialogue.isPlayerInDialogue();
        bool isMoving = false;

        // Move forward
        if (Input.GetKey(KeyCode.W) && !isInDialogue)
        {
            //transform.position += transform.forward * m_Speed;
            Vector3 tempVect = transform.forward;
            tempVect = tempVect.normalized * m_Speed * Time.fixedDeltaTime;
            m_Rigidbody.MovePosition(m_Rigidbody.position + tempVect);
            isMoving = true;
        }

        // Move backward
        if (Input.GetKey(KeyCode.S) && !isInDialogue)
        {
            Vector3 tempVect = transform.forward;
            tempVect = tempVect.normalized * m_Speed * Time.fixedDeltaTime * 0.5f;
            m_Rigidbody.MovePosition(m_Rigidbody.position - tempVect);
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
