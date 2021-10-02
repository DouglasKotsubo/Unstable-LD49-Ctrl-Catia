using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Image textBox;
    public Image face;
    public TextMeshProUGUI text;
    public TextMeshProUGUI name;

    public Queue<string> sentences;

    private void Start(){
        sentences = new Queue<string>();
    }

    public void StartDialogue(DialogueClass dial){
        EnableComponents();
        face = dial.face;
        name.text = dial.name;
        foreach (string dialogue in dial.dialogues)
        {
            sentences.Enqueue(dialogue);
        }
    }

    public void ShowNextDialogue(){
        string Next = sentences.Dequeue();
        text.text = Next;
    }

    private void EnableComponents(){
        textBox.enabled = true;
        face.enabled = true;
        text.gameObject.SetActive(true);
    }
}
