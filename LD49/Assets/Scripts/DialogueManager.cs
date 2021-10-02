using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Image faceBox;
    public Image textBox;
    public Image face;
    public TextMeshProUGUI text;
    public TextMeshProUGUI nome;
    private bool going = false;

    public Queue<string> sentences;
    [HideInInspector]
    public string Next;

    public void StartDialogue(DialogueClass dial){
        EnableComponents();
        sentences = new Queue<string>();
        face = dial.face;
        nome.text = dial.nome;
        foreach (string dialogue in dial.dialogues)
        {
            sentences.Enqueue(dialogue);
            print("1");
        }
    }

    public void ShowNextDialogue(){
        if (going){
            StopAllCoroutines();
            going = false;
            text.text = Next;
            return;
        }
        if (sentences.Count == 0){
            print("Fim do dialogo");
            DisableComponents();
            return;
        }
        StopAllCoroutines();
        Next = sentences.Dequeue();
        text.text = "";
        StartCoroutine(TypeDialogue(Next));
    }

    private void EnableComponents(){
        textBox.enabled = true;
        face.enabled = true;
        faceBox.enabled = true;
        text.gameObject.SetActive(true);
        nome.gameObject.SetActive(true);
    }

    private void DisableComponents(){
        textBox.enabled = false;
        face.enabled = false;
        faceBox.enabled = false;
        text.gameObject.SetActive(false);
        nome.gameObject.SetActive(false);
    }

    private IEnumerator TypeDialogue(string texto){
        going = true;
        foreach (char c in texto.ToCharArray()){
            text.text += c;
            yield return new WaitForSeconds(0.1f);
        }
        going = false;
    }
}
