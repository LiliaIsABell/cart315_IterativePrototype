using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tele_left : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(-29.0f, 0.0f, -33.0f);

        }

    }
}
