using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Transform content;
    public List <GameObject> itens;
    public void AddItem(GameObject item)
    {
        itens.Add(item);
        DesenharItens();
    }

    public void DesenharItens()
    {
        while (content.childCount < itens.Count)
        {
            GameObject item1 = Instantiate (itens[content.childCount], content.position, Quaternion.identity);
            item1.transform.parent = content.transform;    
        }
    }
    void Start()
    {
        DesenharItens();
    }

}
