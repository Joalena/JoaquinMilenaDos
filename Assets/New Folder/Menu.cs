using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;



public class Menu : MonoBehaviour

{
    public string History;



    public void Iniciar()

    {

        SceneManager.LoadScene(History);

    }


    public void Salir()
    {
       
        Application.Quit();

    }
}

   

        
