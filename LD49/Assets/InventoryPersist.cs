using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPersist : MonoBehaviour
{
    public static InventoryPersist instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
