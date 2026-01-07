using UnityEngine;





public class Controller : MonoBehaviour


{
    Rigidbody m_Rigidbody;

    public float m_Speed = 0.1f, m_rotateSpeed = 50.0f;
        public Animator animator; 


    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }





    void Update()


    {
        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            //m_Rigidbody.linearVelocity = transform.forward * m_Speed;
            transform.position += transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            //m_Rigidbody.linearVelocity = -transform.forward * m_Speed;
            transform.position -= transform.forward * m_Speed * 0.5f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_rotateSpeed, Space.World);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_rotateSpeed, Space.World);
        }
    }
}