using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {

    Vector3 spawnPoint;
    /*GameObject spawnObject;*/
    public Transform Pos;

    void Start()
    {
        //spawnObject = GameObject.FindGameObjectWithTag("Player");

        spawnPoint = Pos.position;
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = spawnPoint;
        }
    }

}

