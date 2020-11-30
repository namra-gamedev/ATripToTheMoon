using UnityEngine;
using System.Collections;

public class FreezeTransfo : MonoBehaviour
{

    Rigidbody2D rigBod;
    //Rigidbody2D originalConstraints;
    //new Vector3 posX;
    private bool freeze;

    // Use this for initialization
    void Start()
    {
        rigBod = GetComponent<Rigidbody2D>();
        //originalConstraints = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //posX = new Vector3(GameObject.transform.position.x);
        if (freeze)
        {
            //transform.Translate(Vector3.right * 0f);
        }
    }

    void FreezeT()
    {
        rigBod.constraints = RigidbodyConstraints2D.FreezePositionX;
        rigBod.constraints = RigidbodyConstraints2D.FreezeRotation;
        freeze = true;
    }

    void UnfreezeT()
    {
        freeze = false;
        rigBod.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
        rigBod.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
