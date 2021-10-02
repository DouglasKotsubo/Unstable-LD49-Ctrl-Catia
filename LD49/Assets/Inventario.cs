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
    void DesenharItens()
    {
        while (content.childCount < itens.Count)
        {
            GameObject item = Instantiate(itens[content.childCount], content.position, Quaternion.identity) as GameObject;
            item.transform.parent = content.transform;
        }
    }
    void Start()
    {
        DesenharItens();
    }
}
