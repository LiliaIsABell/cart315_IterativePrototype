using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public string collecttag;
    public Text scoredisplay;
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.gameObject.CompareTag(collecttag))
        {

            Destroy(collision.collider.gameObject);

            score = score + 1;
            scoredisplay.text = score + "/ Marbles";
            

        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (score == 7)
        {
            Debug.Log("WIN!");
        }
    }
}