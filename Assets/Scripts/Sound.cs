using UnityEngine.Audio;
using UnityEngine;

// Code from Brackeys
//https://www.youtube.com/watch?v=6OT43pvUyfY


[System.Serializable]
public class Sound 
{
    public string name;

    public AudioClip clip;


    [Range(0f,1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;
}
