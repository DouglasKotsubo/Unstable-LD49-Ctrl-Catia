using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventario : MonoBehaviour
{

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
    public DialogueManager manager;
    public static Inventario instance;

    void Start(){
        slotItemIndex = new int[5];
        if (SceneManager.GetActiveScene().name == "SampleScene"){
            PlayerPrefs.SetInt("hasFlashlight", 0);
            PlayerPrefs.SetInt("hasKey", 0);
            int i;
            for (i = 0; i < 5; i++) slotItemIndex[i] = -1;
        }
        else if (SceneManager.GetActiveScene().name == "Cena2"){
            AddFlashlight();
            slotItemIndex[0] = 0;
            int i;
            for (i = 1; i < 5; i++) slotItemIndex[i] = -1;
        }
        else if (SceneManager.GetActiveScene().name == "Cena3"){
            AddFlashlight(); AddKey();
            slotItemIndex[0] = 0;
            slotItemIndex[1] = 1;
            int i;
            for (i = 2; i < 5; i++) slotItemIndex[i] = -1;
        }
    }
    public void AddFlashlight(){
        element coletado = allItens[0];
        if (coletado.collected) return;

        allItens[0].collected = true;
        RectTransform current = itemSlots[0].gameObject.GetComponent<RectTransform>();
        current.localScale = current.localScale * coletado.imageResizeScale;
        current.localPosition += coletado.imageOffset;
        current.GetComponent<Image>().sprite = coletado.imagem;
        slotItemIndex[0] = 0;
        PlayerPrefs.SetInt("hasFlashlight", 1);
    }

    public void AddKey(){
        element coletado = allItens[1];
        if (coletado.collected) return;

        allItens[1].collected = true;
        RectTransform current = itemSlots[1].gameObject.GetComponent<RectTransform>();
        current.localScale = current.localScale * coletado.imageResizeScale;
        current.localPosition += coletado.imageOffset;
        current.GetComponent<Image>().sprite = coletado.imagem;
        slotItemIndex[1] = 1;
        PlayerPrefs.SetInt("hasKey", 1);
    }

    public void SlotDescription(int slotIndex){
        if (slotItemIndex[slotIndex] == -1) return;
        manager.ShowDescription(slotItemIndex[slotIndex]);
    }

}
