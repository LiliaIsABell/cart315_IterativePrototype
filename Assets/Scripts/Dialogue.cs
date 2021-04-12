using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour

//Code from Mister Taft Creates on Youtube
//https://www.youtube.com/watch?v=1NCvpZDtTMI
//
{
    public GameObject dialogueBox;
    public TextMeshProUGUI textDisplay;
    public string sentence;
    public bool dialogueActive;


    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dialogueActive)
        {
            if (dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueBox.SetActive(true);
                textDisplay.text = sentence;
            }
           

        }

      
    }

private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueActive = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueActive = false;
            dialogueBox.SetActive(false);
        }
    }

   
}
