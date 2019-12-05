using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_player : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip clip;
    public float volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter()
    {
        audio.PlayOneShot(clip, volume);
        alreadyPlayed = true;
    }
    
}
