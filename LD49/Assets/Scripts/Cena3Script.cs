using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena3Script : MonoBehaviour
{
    public PlayerMove playerMotion;
    public GameObject playerLight;
    public DialogueManager manager;

    [Header("Dialogos")]
    public DialogueClass dialogoInicial;
    public DialogueClass dialogoLixo;
    public DialogueClass dialogoCaixas;

    [Header("Medo")]
    public ScaryTexturing st;
    public GameObject[] tilemaps;
    public GameObject background;

    [Header("Scene")]
    public GameObject trashCan;
    public Transform boxesCoords;

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
            Vector3 distancia = playerMotion.gameObject.GetComponent<Transform>().position - trashCan.GetComponent<Transform>().position;
            if (Input.GetKeyDown(KeyCode.E) && distancia.magnitude <= 1.5){
                manager.StartDialogue(dialogoLixo);
                manager.ShowNextDialogue();
                playerMotion.freezed = true;
                progress++;
            }
        }
        else if (progress == 2){
            if (Input.GetKeyDown(KeyCode.E) && !(manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
            }
            else if (Input.GetKeyDown(KeyCode.E) && (manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
                progress++;
                playerMotion.freezed = false;
            }
        }
        else if (progress == 3){
            Vector3 distancia = playerMotion.gameObject.GetComponent<Transform>().position - boxesCoords.position;
            print(distancia);
            if (Input.GetKeyDown(KeyCode.E) && distancia.magnitude <= 1.5f){
                manager.StartDialogue(dialogoCaixas);
                manager.ShowNextDialogue();
                playerMotion.freezed = true;
                progress++;
            }
        }
        else if (progress == 4){
            if (Input.GetKeyDown(KeyCode.E) && !(manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
            }
            else if (Input.GetKeyDown(KeyCode.E) && (manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
                progress++;
                playerMotion.freezed = false;
            }
        }
        else if (progress == 4){
            StartCoroutine(FuckBackground());
            progress++;
        }
    }

    IEnumerator FuckBackground(){
        yield return new WaitForSeconds(1);
        st.ScaryMaterial(background, 1);
        st.ScaryPostProcessing();
    }
}
