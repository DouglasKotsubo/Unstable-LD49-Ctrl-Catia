using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    /*public RectTransform content;
    public List <GameObject> itens;
    
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
    }*/
    //Antigo código acima

    [System.Serializable]
    public struct element{
        public string nome;
        [TextArea(3,10)]
        public string description;
        public int index;
        public bool collected;
        public Sprite imagem;
        public float imageResizeScale;
        public Vector3 imageOffset;
    };

    public element[] allItens;
    public Image[] itemSlots;
    private int[] slotItemIndex;
    private int slotCounter = 0;
    public DialogueManager manager;

    void Start(){
        slotItemIndex = new int[5];
        int i;
        for (i = 0; i < 5; i++) slotItemIndex[i] = -1;
    }
    public void addItem(int itemIndex){
        element coletado = allItens[itemIndex];
        if (coletado.collected == true) return;
        
        allItens[itemIndex].collected = true;
        itemSlots[slotCounter].sprite = coletado.imagem;
        RectTransform current = itemSlots[slotCounter].gameObject.GetComponent<RectTransform>();
        current.localScale = current.localScale * coletado.imageResizeScale;
        current.localPosition += coletado.imageOffset;
        slotItemIndex[slotCounter] = slotCounter;
        slotCounter++;
        
    }

    public void SlotDescription(int slotIndex){
        if (slotItemIndex[slotIndex] == -1) return;
        manager.ShowDescription(slotItemIndex[slotIndex]);
    }

}
