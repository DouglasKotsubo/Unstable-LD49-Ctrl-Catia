using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena1Script : MonoBehaviour
{
    public PlayerMove playerMotion;
    public GameObject playerLight;
    public DialogueManager manager;
    public GameObject door;

    [Header("Dialogos")]
    public DialogueClass dialogoInicial;
    public DialogueClass dpsDoSusto;
    public DialogueClass flashlightDialogue;

    [Header("Medo")]
    public ScaryTexturing st;
    public GameObject[] tilemaps;

    private int progress = 0;

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
        else if (progress == 1){
            GameObject flashlight = GameObject.Find("flashlight");
            if (flashlight == null){ //Lanterna foi coletada
                playerLight.SetActive(true);
                progress++;
            }
        }
        else if (progress == 2){
            playerMotion.freezed = true;
            manager.StartDialogue(flashlightDialogue);
            manager.ShowNextDialogue();
            progress++;
        }
        else if (progress == 3){
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
            StartCoroutine(WaitForIt());
            progress++;
        }
        else if (progress == 6){
            playerMotion.freezed = true;
            manager.StartDialogue(dpsDoSusto);
            manager.ShowNextDialogue();
            progress++;
        }
        else if (progress == 7){
            if (Input.GetKeyDown(KeyCode.E) && !(manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
            }
            else if (Input.GetKeyDown(KeyCode.E) && (manager.sentences.Count == 0 && !manager.going)){
                manager.ShowNextDialogue();
                progress++;
                playerMotion.freezed = false;
            }
        }
        else if (progress == 8){
            door.SetActive(true);
            progress++;
        }
        else if (progress == 9){
            if (Input.GetKeyDown(KeyCode.E)){
                Vector3 distancia = playerMotion.gameObject.GetComponent<Transform>().position - door.GetComponent<Transform>().position;
                if (distancia.magnitude <= 1.5f){
                    SceneManager.LoadScene("Cena2");
                }
            }
        }
    }

    IEnumerator WaitForIt(){
        yield return new WaitForSeconds(4);
        //st.ScaryMaterial(playerMotion.gameObject, 1);
        foreach (GameObject obj in tilemaps){
            st.ScaryMaterial(obj, 1);
        }
        st.ScaryPostProcessing();
        yield return new WaitForSeconds(1.5f);
        foreach (GameObject obj in tilemaps){
            st.NormalMaterial(obj);
        }
        yield return new WaitForSeconds(1);
        progress++;
    }
}
