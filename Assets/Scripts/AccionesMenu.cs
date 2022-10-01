using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccionesMenu : MonoBehaviour
{
    public void Empezar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Tienda()
    {

    }
    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
