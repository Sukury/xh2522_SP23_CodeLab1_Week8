using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{
    
    
    public float PCRotationSpeed = 10;
    
    public void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * PCRotationSpeed;
        float rotY = Input.GetAxis("Mouse Y") * PCRotationSpeed;
        
        transform.Rotate(Vector3.down, rotX, Space.World);
        transform.Rotate(Vector3.right,rotY,Space.World);

    }
}
