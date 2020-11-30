using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFuite : MonoBehaviour
{
    public AudioSource music;

    //public DeadKing roi;

    static bool AudioBegin = false;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    void Awake()
    {
        if (!AudioBegin)
        {
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        /*if (roi.kingDead == true)
        {
            music.Play();
            roi.kingDead = false;
        }*/
        /*if (Application.loadedLevelName == "Escape04")
        {
            music.Stop();
            AudioBegin = false;
        }*/
    }
}
