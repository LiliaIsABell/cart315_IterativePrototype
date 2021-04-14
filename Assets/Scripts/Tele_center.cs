using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tele_center : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        other.transform.position = new Vector3(-6.0f, 0.0f, -8.0f);
        
        }
        
    }
}
