using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            anim.Play("WAIT01", -1, 0f);
        }

        if(Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }

        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", -1, 0f);
        }

        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT04", -1, 0f);
        }


    }
}
