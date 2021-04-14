using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tele_right : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(19.5f, 0.0f, -34.0f);

        }

    }
}
