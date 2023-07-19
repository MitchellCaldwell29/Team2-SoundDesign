using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class SoundRandomiser : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioMixerGroup output;

    public float minPitch = .95f;
    public float maxPitch = 1.05f; 

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")) // change for arrow keys later 
        {
            PlaySound();
        }

    } 

    void PlaySound()
    {
        //Randomize
        int randomClip = Random.Range (0, clips.Length);

        //Create an AudioSource
        AudioSource source = gameObject.AddComponent<AudioSource>();

        //Load clip into Audiosource
        source.clip = clips[randomClip];

        // Set the output for AudioSource
        source.outputAudioMixerGroup = output; 

        // Set the pitch to randomize
        source.pitch = Random.Range (minPitch, maxPitch);

        //Play the clip
        source.Play ();

        //Destroy the AudioSource when done playing clip
        Destroy(source, clips[randomClip].length);
    }

}

