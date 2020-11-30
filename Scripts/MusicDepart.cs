using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDepart : MonoBehaviour
{
    AudioSource music;

    static bool AudioBegin = false;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    void Awake()
    {
        if (!AudioBegin)
        {
            //music.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "Moon03")
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
            music.volume -= Time.deltaTime / 2;
            yield return null;
        }
        music.volume = 0;
        music.Stop();
    }
}