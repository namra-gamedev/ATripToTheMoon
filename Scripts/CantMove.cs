using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantMove : MonoBehaviour
{
    Rigidbody2D rigBod;
    // Start is called before the first frame update
    void Start()
    {
        rigBod = GetComponent<Rigidbody2D>();
        rigBod.constraints = RigidbodyConstraints2D.FreezePositionX;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
