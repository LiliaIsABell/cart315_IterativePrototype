using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public string collecttag;
    public Text scoredisplay;
    int score = 0;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag(collecttag))
        {

            Destroy(collision.gameObject);

            score = score + 1;
            scoredisplay.text = score + " /"+ " 7 Marbles";
            

            FindObjectOfType<AudioManager>().Play("marbleCollected");

        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (score == 7)
        {
            SceneManager.LoadScene(2);
            
        }
    }
}