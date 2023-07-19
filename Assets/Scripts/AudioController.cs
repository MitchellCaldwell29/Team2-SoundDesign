using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip[] clips;
    public float minTime;
    public float maxTime;
    private int clipIndex;
    private AudioSource audio;
    private bool audioPlaying = false;

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (!audio.isPlaying)
        {
            clipIndex = Random.Range(0, clips.Length);
            audio.clip = clips[clipIndex];
            audio.PlayDelayed(Random.Range(minTime, maxTime));
            Debug.Log("Nothing playing, we set new audio to " + audio.clip.name);
        }
    }
}