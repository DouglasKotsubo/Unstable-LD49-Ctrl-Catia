using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScript : MonoBehaviour
{
    /*private Vector3 distance;
    private Transform player;
    public float interactableDistance;
    public Inventario inventory;
    public GameObject fuedase;

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

    private void CollectObject()
    {
        inventory.AddItem(fuedase);
    }*/
    public Inventario inv;
    public float interactableDistance;
    public Transform player;
    public int identifier;
    private Vector3 distance;
    void Update(){
        distance = player.position - transform.position;
        if (distance.magnitude <= interactableDistance && Input.GetKeyDown(KeyCode.E)){
            inv.addItem(identifier);
            Destroy(gameObject);
        }
    }
}
