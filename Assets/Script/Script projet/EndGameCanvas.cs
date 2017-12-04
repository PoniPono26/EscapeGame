using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCanvas : MonoBehaviour
{


    public Canvas EndGame;

    void Start()
    {
        EndGame.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EndGame.enabled = true;
        }
    }
}