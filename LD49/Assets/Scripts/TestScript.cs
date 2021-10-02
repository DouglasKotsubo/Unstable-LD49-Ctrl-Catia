using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject dialogoTeste;
    public GameObject manager;

    void Start()
    {
        manager.GetComponent<DialogueManager>().StartDialogue(dialogoTeste.GetComponent<DialogueClass>());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            manager.GetComponent<DialogueManager>().ShowNextDialogue();
        }
    }
}
