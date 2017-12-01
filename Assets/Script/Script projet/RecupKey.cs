using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecupKey : MonoBehaviour
{
    public Transform Door;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            
            obj.gameObject.GetComponent<KeysScript>().AddKey();
            // if (obj.gameObject.GetComponent<KeysScript>().CanOpenDoor()){
            //open door
            Destroy(gameObject);
        }
    }
}

