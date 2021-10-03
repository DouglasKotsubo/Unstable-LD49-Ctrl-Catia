using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena1Script : MonoBehaviour
{
    public PlayerMove playerMotion;
    public GameObject playerLight;
    public DialogueManager manager;
    public DialogueClass dialogoInicial;
    public ScaryTexturing st;
    public GameObject[] tilemaps;

    private int progress = 0;

    void Start()
    {
        manager.StartDialogue(dialogoInicial);
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
            StartCoroutine(WaitForIt());
            progress++;
        }
    }

    IEnumerator WaitForIt(){
        yield return new WaitForSeconds(4);
        //st.ScaryMaterial(playerMotion.gameObject, 1);
        foreach (GameObject obj in tilemaps){
            st.ScaryMaterial(obj, 1);
        }
        st.ScaryPostProcessing();
    }
}
