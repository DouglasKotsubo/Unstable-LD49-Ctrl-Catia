using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public DialogueClass dialogos;
    public DialogueManager manager;

    void Start()
    {
        manager.StartDialogue(dialogos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            manager.ShowNextDialogue();
        }
    }
}
