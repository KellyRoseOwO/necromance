using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  
    public Vector3 offset;     

    void LateUpdate()
    {
        Vector3 newPos = transform.position;
        newPos.z = player.position.z + offset.z;
        transform.position = newPos;
    }
}
