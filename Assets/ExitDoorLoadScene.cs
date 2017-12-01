using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorLoadScene : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Perso")
        {
            SceneManager.LoadScene(0);
        }
    }


}

