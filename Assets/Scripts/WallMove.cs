using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public Vector3 startPos;
    public float distance = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         transform.position = startPos + new Vector3(0.0f, Mathf.Sin(Time.time) * distance, 0.0f);
    }
}
