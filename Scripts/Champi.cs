using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champi : MonoBehaviour
{
    public GameObject champ;
    public GameObject spawner;
    public GameObject champTop;

    [SerializeField]
    private float wait;

    private Animation anim;

    private bool cooldown = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && (cooldown == false))
        {
            cooldown = true;
            StartCoroutine(Attendre());
            Attendre();
        }
    }

    void Champignon()
    {
            anim = champTop.GetComponentInChildren<Animation>();
            Instantiate(champ, spawner.transform.position, transform.rotation);
            anim.Play();
    }

    IEnumerator Attendre()
    {
        yield return new WaitForSeconds(wait);
        Champignon();
        yield return new WaitForSeconds(1.5f);
        cooldown = false;
    }

}
