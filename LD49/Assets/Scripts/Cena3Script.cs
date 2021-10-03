using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena3Script : MonoBehaviour
{
    public PlayerMove playerMotion;
    public GameObject playerLight, door;
    public DialogueManager manager;

    [Header("Dialogos")]
    public DialogueClass dialogoInicial;

    [Header("Medo")]
    public ScaryTexturing st;
    public GameObject[] tilemaps;

    private int progress = 0;
    // Start is called before the first frame update
    void Start()
    {
        manager.StartDialogue(dialogoInicial);
        manager.ShowNextDialogue();
        playerMotion.freezed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (progress == 0){
            if (Input.GetKeyDown(KeyCode.E) && !(manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
            }
            else if (Input.GetKeyDown(KeyCode.E) && (manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
                progress++;
                playerMotion.freezed = false;
            }
        }
        else if (progress == 1)
        {
            
        }
    }
}
