using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10);
    }
}
