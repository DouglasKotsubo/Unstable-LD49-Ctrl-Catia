using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Lights1 : MonoBehaviour
{
    public Light2D lights;
    public GameObject Player;
    public float value;
    Vector3 s0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //Arrumar a direção
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (lights.intensity == 0f)
            {
                lights.intensity = value;
            }
            else
            {
                lights.intensity = 0f;
            }
        }
        transform.position = Player.transform.position;
        if (Input.GetKey("d"))
        {transform.eulerAngles = new Vector3(0,0,0);}
        if (Input.GetKey("a"))
        {transform.eulerAngles = new Vector3(0,0,180);}
        if (Input.GetKey("s"))
        {transform.eulerAngles = new Vector3(0,0,-90);}
        if (Input.GetKey("w"))
        {transform.eulerAngles = new Vector3(0,0,90);}
    }
}
