using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena3Script : MonoBehaviour
{
    public PlayerMove playerMotion;
    public GameObject playerLight, door;
    public DialogueManager manager;
    public AudioSource doorS;

    [Header("Dialogos")]
    public DialogueClass dialogoInicial;

    [Header("Medo")]
    public ScaryTexturing st;
    public GameObject[] tilemaps;

    private int progress = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
