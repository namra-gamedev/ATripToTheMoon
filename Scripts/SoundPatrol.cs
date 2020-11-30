using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPatrol : MonoBehaviour
    {
    AudioSource marche;

    // Start is called before the first frame update
    void Start()
{
    marche = GetComponent<AudioSource>();
    marche.volume = 0;
}

// Update is called once per frame
void Update()
{

}

public AudioSource AddAudio(bool loop, bool playAwake, float vol)
{
    AudioSource newAudio = gameObject.AddComponent<AudioSource>();

    newAudio.loop = loop;
    newAudio.playOnAwake = playAwake;
    newAudio.volume = vol;
    return newAudio;
}

//sons
void AudioMarchePlay()
{
    marche.volume = 1;
}
void AudioMarcheStop()
{
    marche.volume = 0;
}

}

