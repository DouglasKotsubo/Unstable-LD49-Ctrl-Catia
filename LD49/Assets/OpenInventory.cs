using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public Transform inventoryMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            if (inventoryMenu.gameObject.activeSelf)
            {
                inventoryMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                inventoryMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
