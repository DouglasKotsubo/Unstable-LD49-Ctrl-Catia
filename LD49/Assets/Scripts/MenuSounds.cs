using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSounds : MonoBehaviour
{
    public AudioSource hover;
    public AudioSource click;
    
    public void PlayHover(){
        hover.Play();
    }

    public void PlayClick(){
        click.Play();
    }
}
