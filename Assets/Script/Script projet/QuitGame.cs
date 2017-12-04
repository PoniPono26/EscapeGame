using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           
           Application.Quit();
        }
    }
       
    public void QuitOnClick()
    {
        
        Application.Quit();
    }
}

