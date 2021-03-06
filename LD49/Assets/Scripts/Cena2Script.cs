using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena2Script : MonoBehaviour
{
    public PlayerMove playerMotion;
    public GameObject playerLight;
    GameObject item;

    public DialogueManager manager;
    public GameObject door1, door2, door3;

    public GameObject tileMap1;
    public ScaryTexturing st;

    [Header("Dialogos")]
    public DialogueClass dialogoInicial, 
    dialogoDoor3, dialogoDoor2, dialogoDoor1,
    dialogoKey, dialogoUnlock;

    private int progress = 0;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        item = GameObject.Find("item");
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
            Vector3 distancia1 = playerMotion.gameObject.GetComponent<Transform>().position - door1.GetComponent<Transform>().position;
            Vector3 distancia2 = playerMotion.gameObject.GetComponent<Transform>().position - door2.GetComponent<Transform>().position;
            Vector3 distancia3 = playerMotion.gameObject.GetComponent<Transform>().position - door3.GetComponent<Transform>().position;
            if (distancia1.magnitude <= 1.5f && Input.GetKeyDown(KeyCode.E))
            {
                if (count == 0){
                    manager.StartDialogue(dialogoDoor1);
                    count++;
                }
                if (!(manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = true;
                }
                else if ((manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = false;
                    count = 0;
                }
            }
            else if (distancia2.magnitude <= 1.5f && Input.GetKeyDown(KeyCode.E))
            {
                if (count == 0){
                    manager.StartDialogue(dialogoDoor2);
                    count++;
                }
                if (!(manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = true;
                }
                else if ((manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = false;
                    count = 0;
                }
            }
            else if (distancia3.magnitude <= 1.5f && Input.GetKeyDown(KeyCode.E))
            {
                if (count == 0){
                    manager.StartDialogue(dialogoDoor3);
                    count++;
                }
                if (!(manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = true;
                }
                else if ((manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = false;
                    count = 0;
                }
            }
            else if (item == null)
            {
                progress++;            }
        }
        else if (progress == 2)
        {
            FindObjectOfType<AudioManager>().Send("KeySound");
            manager.StartDialogue(dialogoKey);
            manager.ShowNextDialogue();
            playerMotion.freezed = true;
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
            StartCoroutine(ApplyTextures());
            progress++;
        }
        else if (progress == 6){
            Vector3 distancia1 = playerMotion.gameObject.GetComponent<Transform>().position - door1.GetComponent<Transform>().position;
            Vector3 distancia2 = playerMotion.gameObject.GetComponent<Transform>().position - door2.GetComponent<Transform>().position;
            Vector3 distancia3 = playerMotion.gameObject.GetComponent<Transform>().position - door3.GetComponent<Transform>().position;
            if (distancia1.magnitude <= 1.5f && Input.GetKeyDown(KeyCode.E))
            {
                if (count == 0){
                    manager.StartDialogue(dialogoDoor1);
                    count++;
                }
                if (!(manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = true;
                }
                else if ((manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = false;
                    count = 0;
                }
            }
            else if (distancia2.magnitude <= 1.5f && Input.GetKeyDown(KeyCode.E))
            {
                if (count == 0)
                {
                    FindObjectOfType<AudioManager>().Send("UnlockSound");
                    manager.StartDialogue(dialogoUnlock);
                    count++;
                }
                if (!(manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = true;
                }
                else if ((manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = false;
                    FindObjectOfType<AudioManager>().Send("DoorSound");
                    SceneManager.LoadScene("Cena3");
                }
            }
            else if (distancia3.magnitude <= 1.5f && Input.GetKeyDown(KeyCode.E))
            {
                if (count == 0){
                    manager.StartDialogue(dialogoDoor3);
                    count++;
                }
                if (!(manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = true;
                }
                else if ((manager.sentences.Count == 0 && !manager.going)){
                    manager.ShowNextDialogue();
                    playerMotion.freezed = false;
                    count = 0;
                }
            }
        }
            
    }

    IEnumerator ApplyTextures(){
        yield return new WaitForSeconds(2);
        FindObjectOfType<AudioManager>().Send("Boo2");
        st.ScaryMaterial(tileMap1, 1);
        st.ScaryPostProcessing();
        progress++;
    }
}
