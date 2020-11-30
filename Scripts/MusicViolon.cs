using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicViolon : MonoBehaviour
{
    public AudioSource music;
    public AudioClip clip;

    static bool AudioBegin = false;

    void Awake()
    {
        if (!AudioBegin)
        {
            //music.Play();
            StartCoroutine("fadeIn");
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
        if (music == null)
        {
            music = GetComponent<AudioSource>();
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "Moon08")
        {
            //music.Stop();
            StartCoroutine("fadeSound");

            AudioBegin = false;
        }
        if (Application.loadedLevelName == "Moon12")
        {
            //music.Stop();
            StartCoroutine("fadeSound");

            AudioBegin = false;
        }
    }

    IEnumerator fadeSound()
    {
        while (music.volume > 0.01f)
        {
            music.volume -= Time.deltaTime / 3;
            yield return null;
        }
        music.volume = 0;
        music.Stop();
    }

    IEnumerator fadeIn()
    {
        while (music.volume < 0.3f)
        {
            music.volume += Time.deltaTime / 3;
            yield return null;
        }
    }
}