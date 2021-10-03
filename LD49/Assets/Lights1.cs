using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights1 : MonoBehaviour
{
    public GameObject Player;
    public int distance;
    Vector3 s0;
    // Start is called before the first frame update
    void Start()
    {
        s0 = Player.transform.position + distance * new Vector3 (1,0,0);
        transform.position = s0;
    }

    // Update is called once per frame
    //Arrumar a direção
    void Update()
    {
        transform.position = Player.transform.position + distance * new Vector3 (1,0,0);
        if (Input.GetKey("d"))
        {transform.eulerAngles = new Vector3(0,0,0);}
        if (Input.GetKey("a"))
        {transform.eulerAngles = new Vector3(0,0,180);
        transform.position = Player.transform.position + distance * new Vector3 (0,1,0);}
        if (Input.GetKey("s"))
        {transform.eulerAngles = new Vector3(0,0,-90);}
        if (Input.GetKey("w"))
        {transform.eulerAngles = new Vector3(0,0,90);}
    }
}
