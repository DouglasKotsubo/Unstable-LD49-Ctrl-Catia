using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    int count = 0;
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
             GameObject item2 = Instantiate (itens[count], content.position, Quaternion.identity) as GameObject;
             item2.transform.parent = content.transform;
             count++;
    }
    void Start()
    {
        DesenharItens();
    }

}
