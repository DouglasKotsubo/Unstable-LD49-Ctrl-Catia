using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    public Animator anim;
    bool clicked = false;
    public void Começar()
    {
        if (!clicked) StartCoroutine(FadeScreen());
        clicked = true;
    }

    IEnumerator FadeScreen(){
        anim.gameObject.SetActive(true);
        anim.SetTrigger("go");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }
}
