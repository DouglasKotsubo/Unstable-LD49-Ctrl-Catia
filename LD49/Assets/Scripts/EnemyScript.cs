using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    Vector3 diff;
    public int vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diff = player.transform.position - transform.position;
        transform.position += diff * vel * Time.deltaTime / diff.magnitude;
    }
    
}
