using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;

public class ScaryTexturing : MonoBehaviour
{
    public Material[] scaryMaterials;
    public Material normal; //SPRITES-LIT é o default
    public GameObject PPProfile;

    public void ScaryMaterial(GameObject obj, int index){
        if (obj.GetComponent<SpriteRenderer>() != null){
            obj.GetComponent<SpriteRenderer>().material = scaryMaterials[index];
        }
        else if (obj.GetComponent<TilemapRenderer>() != null){
            obj.GetComponent<TilemapRenderer>().material = scaryMaterials[index];
        }
    }

    public void NormalMaterial(GameObject obj){
        if (obj.GetComponent<SpriteRenderer>() != null){
            obj.GetComponent<SpriteRenderer>().material = normal;
        }
        else if (obj.GetComponent<TilemapRenderer>() != null){
            obj.GetComponent<TilemapRenderer>().material = normal;
        }
    }

    public void ScaryPostProcessing(){
        PPProfile.SetActive(true);
    }
    public void ResetPostProcessing(){
        PPProfile.SetActive(false);
    }
}
