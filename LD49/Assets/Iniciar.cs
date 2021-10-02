using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    public void Começar()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
