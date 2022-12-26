using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainHud : MonoBehaviour
{
    public Text contadorNoes;
    public static int Noes = 0;
    
    

    void Start()
    {
       
    }

    void Update()
    {

        contadorNoes.text = "DAÑO DE MUERTO: " + Noes.ToString();

        if (Noes == 500 && SceneManager.GetActiveScene().name == "SampleScene 1")
        {
            SceneManager.LoadScene(2);
        }

        if(Noes == 1000 && SceneManager.GetActiveScene().name == "Final")
        {
            SceneManager.LoadScene(5);
        }

    }

    
   
}
