using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRunLeft : MonoBehaviour
{
    //public RigidBody2D rb;
    private bool moveRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            transform.localScale = new Vector3(1.3f, 1.15f, 1f);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-7, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
}