using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from Acacia Developer
// https://www.youtube.com/watch?v=PmIPqGqp8UY

public class CameraMove : MonoBehaviour
{
   public Transform playerCamera = null;
   public float mouseSensitivity = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      UpdateMouseLook();
    }

    void UpdateMouseLook()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
    }
}
