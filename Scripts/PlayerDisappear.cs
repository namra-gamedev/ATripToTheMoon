using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDisappear : MonoBehaviour
{
    public GameObject vaisseau;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = vaisseau.GetComponent<Animator>();
        anim.enabled = false;
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
        }
    }
    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("ShootMoon", LoadSceneMode.Single);
    }
}
