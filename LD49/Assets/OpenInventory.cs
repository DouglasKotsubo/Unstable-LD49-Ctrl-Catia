using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public DialogueManager manager;
    public GameObject inventoryMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryMenu.activeSelf)
            {
                inventoryMenu.SetActive(false);
                manager.CloseInventory();
                Time.timeScale = 1;
            }
            else
            {
                inventoryMenu.SetActive(true);
                manager.InventoryMode();
                Time.timeScale = 0;
            }
        }
    }
}
