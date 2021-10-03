using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryClass : MonoBehaviour
{
    public string name;
    public int index;
    [TextArea (3,10)]
    public string description;
    public bool collected;
    public Sprite image;
    public float Resize;
    public Vector3 position;
    public GameObject interagir; //botao?
}
