using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public float sensitivity = 2.0f;
    public float maxYAngle = 80.0f;
    private float rotationX = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveMouse();
    }

    void MoveMouse()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.parent.Rotate(Vector3.up * mouseX * sensitivity);
        rotationX -=mouseY * sensitivity;
        rotationX= Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);
        transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);
    }
}
