using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector3();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) direction = Vector3.right;
        else if (Input.GetKey(KeyCode.A)) direction = Vector3.left;
        else direction = Vector3.zero;
    }

    void FixedUpdate(){
        rb.velocity = direction * speed * Time.fixedDeltaTime;
    }
}
