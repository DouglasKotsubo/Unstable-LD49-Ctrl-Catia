using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryElement : MonoBehaviour
{
    [System.Serializable]
    public struct element{
        public string nome;
        [TextArea(3,10)]
        public string description;
        public Sprite imagem;
        public bool collected;
        public int index;
    };
    public static element[] allItens;
    
}
