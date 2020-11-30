using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject explosion;

    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene name is: " + scene.name + "\nActive Scene index: " + scene.buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(player);
            Instantiate(explosion, player.transform.position, player.transform.rotation);
            //SceneManager.LoadScene(scene.buildIndex, LoadSceneMode.Single);
            Debug.Log("mort");
            StartCoroutine(coroutine());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(player);
            Instantiate(explosion, player.transform.position, player.transform.rotation);
            //SceneManager.LoadScene(scene.buildIndex, LoadSceneMode.Single);
            Debug.Log("mort");
            StartCoroutine(coroutine());
        }
    }

    private IEnumerator coroutine()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(scene.buildIndex, LoadSceneMode.Single);
    }

    private void Reload()
    {
        SceneManager.LoadScene(scene.buildIndex, LoadSceneMode.Single);
    }
}
