using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jogar()
    {

        SceneManager.LoadScene(1);
    }
    public void Salida()
    {
        Application.Quit();
    }

    public void alComienzo()
    {
        SceneManager.LoadScene(0);
    }
}
