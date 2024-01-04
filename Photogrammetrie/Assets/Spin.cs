using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;
    bool rotateRight = false;
    bool rotateLeft = false;

    private void Update()
    {
        if(rotateRight)
        {
            transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime, Space.World);
        }
        else if (rotateLeft)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        }
    }

    public void OnPressRight()
    {
        rotateRight = true;
    }

    public void ReleasedRight()
    {
        rotateRight = false;
    }

    public void OnPressLeft()
    {
        rotateLeft = true;
    }

    public void ReleasedLeft()
    {
        rotateLeft = false;
    }
}
