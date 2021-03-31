using UnityEngine.Audio;
using System;
using UnityEngine;

// Code from Brackeys
//https://www.youtube.com/watch?v=6OT43pvUyfY

public class AudioManager : MonoBehaviour
{

    public Sound[] sound;

  
    void Awake()
    {
        foreach (Sound s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
        }
    }

    
    public void Play(string name)
    {
        Sound s = Array.Find(sound, sound => sound.name == name);
        s.source.Play();
    }
}
