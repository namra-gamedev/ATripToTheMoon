using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadKing : MonoBehaviour
{
    public bool kingDead = false;
    public SpriteRenderer image;
    public GameObject explosion;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public MusicFuite musique;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "AttackHitBox")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            image.color = new Color(0, 0, 0, 0);
            kingDead = true;
            Instantiate(enemy1, spawn1.transform.position, spawn1.transform.rotation);
            Instantiate(enemy2, spawn2.transform.position, spawn2.transform.rotation);
            Instantiate(enemy3, spawn3.transform.position, spawn3.transform.rotation);
            GetComponent<BoxCollider2D>().enabled = false;
            musique.music.Play();
        }
    }
}
