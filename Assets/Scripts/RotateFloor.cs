using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFloor : MonoBehaviour
{

    public float rotationSpeed = 10.0f;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * rotationSpeed);
    }
}
