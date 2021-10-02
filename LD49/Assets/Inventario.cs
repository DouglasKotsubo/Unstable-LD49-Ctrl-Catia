using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public RectTransform content;
    public List <GameObject> itens;
    public class item1
    {
        public string nome, descricao;
        public SpriteRenderer imagem;
    }
    public void AddItem(GameObject item)
    {
        itens.Add(item);
        DesenharItens();
    }

    public void DesenharItens()
    {
        if (content.childCount < itens.Count)
        {
             GameObject item2 = Instantiate (itens[content.childCount], content.position, Quaternion.identity) as GameObject;
             item2.transform.parent = content.transform;
        }
    }
    void Start()
    {
        DesenharItens();
    }

}
