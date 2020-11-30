using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LuneTombe : MonoBehaviour
{
    public GameObject vaisseau;
    private Animator anim;

    private MusicFuite musique;
    // Start is called before the first frame update
    void Start()
    {
        anim = vaisseau.GetComponent<Animator>();
        anim.enabled = false;

        musique = GameObject.Find("MusicKingFuite").GetComponent<MusicFuite>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector3(0, 30, 0);
            anim.enabled = true;
            StartCoroutine(coroutine());
            musique.music.Stop();
        }
    }
    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(3.4f);
        SceneManager.LoadScene("Escape04", LoadSceneMode.Single);
    }
}
