using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class audio_manager : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    public float volume = 1;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public cube Cube;
    public GameObject textBox1;
    public GameObject textBox2;
    private float time = 0f;
    private float zx = 0f;
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
                textBox2.SetActive(true);
                zx = time + Time.deltaTime;
                if (zx>=10)
                {
                    textBox2.SetActive(false);
                }
                
            }
            else
            {
                Debug.Log("play2");
                audio.PlayOneShot(clip2, volume);
                alreadyPlayed = true;
                Debug.Log("subtitles");
                textBox1.SetActive(true);
                if (zx >= 10)
                {
                    textBox2.SetActive(false);
                }
            }


        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
