using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundCollider : MonoBehaviour
{
    public float timer;
    public AudioClip son;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        audioSource.PlayOneShot(son, 0.7F);
        DontDestroyOnLoad(audioSource);
        StartCoroutine(coroutine());
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        audioSource.PlayOneShot(son, 0.7F);
        DontDestroyOnLoad(audioSource);
        StartCoroutine(coroutine());
    }

    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
    }
}