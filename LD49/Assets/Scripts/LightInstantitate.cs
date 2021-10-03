using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInstantitate : MonoBehaviour
{
    public Inventario inventario;
    int invocar;
    public GameObject lanterna;
    public GameObject lanternaprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inventario.SlotDescription(1) == 1 && invocar == 0)
        {
            lanterna = Instantiate(lanternaprefab);
            invocar = 1;
        }
    }
}
