using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScript : MonoBehaviour
{
    private Vector3 distance;
    private Transform player;
    public float interactableDistance;
    public Inventario inventory;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.position - transform.position;
        if (distance.magnitude <= interactableDistance && Input.GetKeyDown(KeyCode.E)){
            CollectObject();
        }
    }

    private void CollectObject(){
        inventory.AddItem(gameObject);
        print("okk");
    }
}
