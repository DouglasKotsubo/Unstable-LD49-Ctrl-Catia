using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterAlinhar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (transform.parent.position - transform.position) * 10 * Time.deltaTime;
    }
}
