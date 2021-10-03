using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public AudioSoundClass[] sounds;

    // Start is called before the first frame update
    void Start()
    {
        foreach (AudioSoundClass s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
        AudioSoundClass s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
