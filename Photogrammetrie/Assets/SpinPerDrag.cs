using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPerDrag : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10;
 
    private void OnMouseDrag()
    {
        //print("dragging");
        float rotY = Input.GetAxis("Mouse Y") * rotationSpeed;
        float rotX = Input.GetAxis("Mouse X") * rotationSpeed;
 
        transform.Rotate(Vector3.up, -rotX, Space.World);
        transform.Rotate(Vector3.right, -rotY, Space.World);
    }
}
