using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AudioSoundClass : MonoBehaviour
{
    public string name;
    public AudioClip clip;
    
    [Range (0f, 1f)]
    public float volume;
    [Range (0f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
