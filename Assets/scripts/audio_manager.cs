using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_manager : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    public float volume = 1;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public cube Cube;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter()
    {
        if (!alreadyPlayed) 
        {
            if (!Cube.isDestroyed)
            {
                Debug.Log("play1");
                audio.PlayOneShot(clip1, volume);
                alreadyPlayed = true;
            }
            else
            {
                Debug.Log("play2");
                audio.PlayOneShot(clip2, volume);
                alreadyPlayed = true;
            }


        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
