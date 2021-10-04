using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    Vector3 direction;

    [HideInInspector]
    public bool freezed = false;
    private float stepCounter = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector3();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) direction = Vector3.right;
        else if (Input.GetKey(KeyCode.A)) direction = Vector3.left;
        else if (Input.GetKey(KeyCode.W)) direction = Vector3.up;
        else if (Input.GetKey(KeyCode.S)) direction = Vector3.down;
        else direction = Vector3.zero;
        if (direction != Vector3.zero){
            if (stepCounter >= 0.4f){
                FindObjectOfType<AudioManager>().Send("FootstepSound");
                stepCounter = 0;
            } 
            stepCounter += Time.deltaTime;
        }
    }

    void FixedUpdate(){
        if (!freezed) rb.velocity = direction * speed * Time.fixedDeltaTime;
        else rb.velocity = Vector3.zero;
    }
}
