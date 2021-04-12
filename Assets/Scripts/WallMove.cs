using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
  
    public GameObject wall;
    public bool nearWall;
    
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (nearWall)
        {
            if (wall.activeInHierarchy)
            {
                wall.SetActive(false);
            }
            else
            {
                wall.SetActive(true);
            }


        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            nearWall = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            nearWall = false;
            wall.SetActive(false);
        }
    }
}
