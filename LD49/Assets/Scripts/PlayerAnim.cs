using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            anim.SetBool("goingRight", true);
        }
        else anim.SetBool("goingRight", false);

        if (Input.GetKey(KeyCode.A)){
            anim.SetBool("goingLeft", true);
        }
        else anim.SetBool("goingLeft", false);

        if (Input.GetKey(KeyCode.W)){
            anim.SetBool("goingUp", true);
        }
        else anim.SetBool("goingUp", false);

        if (Input.GetKey(KeyCode.S)){
            anim.SetBool("goingDown", true);
        }
        else anim.SetBool("goingDown", false);
    }
}
