using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from Brackeys
// https://www.youtube.com/watch?v=_QajrabyTJc&t=622s

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        
    }
}
