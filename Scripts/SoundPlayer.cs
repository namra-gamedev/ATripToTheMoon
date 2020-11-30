using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    AudioSource marche;

    public AudioClip sautclip;
    AudioSource saut;

    public AudioClip fallclip;
    AudioSource fall;

    public AudioClip champclip;
    AudioSource champ;

    public AudioClip atkclip;
    AudioSource atk;



    // Start is called before the first frame update
    void Start()
    {
        marche = GetComponent<AudioSource>();
        marche.volume = 0;

        saut = AddAudio(false, false, 0.4f);
        fall = AddAudio(false, false, 0.4f);
        champ = AddAudio(false, false, 0.4f);
        atk = AddAudio(false, false, 0.4f);
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
        StartCoroutine("fadeIn");
        //marche.volume = 1;
    }
    void AudioMarcheStop()
    {
        StartCoroutine("fadeOut");
        //marche.volume = 0;
    }
    void AudioSaut()
    {
        saut.clip = sautclip;
        saut.Play();
    }
    void AudioFall()
    {
        fall.clip = fallclip;
        fall.Play();
    }

    void AudioChamp()
    {
        champ.clip = champclip;
        champ.Play();
    }
    void AudioAttack()
    {
        atk.clip = atkclip;
        atk.Play();
    }

    IEnumerator fadeOut()
    {
        while (marche.volume > 0.01f)
        {
            marche.volume -= Time.deltaTime / 0.1f;
            yield return null;
        }
        marche.volume = 0;
    }

    IEnumerator fadeIn()
    {
        while (marche.volume < 1f)
        {
            marche.volume += Time.deltaTime / 0.1f;
            yield return null;
        }
    }
}
