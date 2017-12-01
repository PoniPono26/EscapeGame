using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenZoneDoorKey : MonoBehaviour
{
    public GameObject player;
    KeysScript PlayerKeysScript;

    public float maxOpenValue1;
    public float maxOpenValue2;

    public Transform Door1;
    public Transform Door2;

    public bool open = false;
    public bool closing = true;

    private float currentValue1 = 0;
    private float currentValue2 = 0;

    // Use this for initialization
    void Start()
    {
        PlayerKeysScript = player.GetComponent<KeysScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (open) OpenDoor();
        if (closing) CloseDoor();
    }

    void OnTriggerEnter(Collider obj)
    {
      
        if (obj.transform.name == "Perso" && PlayerKeysScript.CanOpenDoor())
        {
            open = true;
            closing = false;
         
        }

    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.transform.name == "Perso")
        {
            open = false;
            closing = true;
       
        }
    }


    void OpenDoor()
    {
        float movement1 = -1.0f * Time.deltaTime;
        currentValue1 += movement1;
       
        if (currentValue1 <= maxOpenValue1)
        {
            Door1.position = new Vector3(
                Door1.position.x ,
                Door1.position.y,
                Door1.position.z + movement1
                );
        }
        else
        {
            open = false;
           
        }

       float movement2 = 1.0f * Time.deltaTime;
        currentValue2 += movement2;

        if (currentValue2 >= maxOpenValue2)
        {
            Door2.position = new Vector3(
                Door2.position.x,
                Door2.position.y,
                Door2.position.z + movement2
                );
        }
        else
        {
            open = false;
           
        }
    }

    void CloseDoor()
    {
        float movement1 = -1.0f * Time.deltaTime;
        currentValue1 -= movement1;

        if (currentValue1 <= 0)
        {
            Door1.position = new Vector3(
                Door1.position.x,
                Door1.position.y,
                Door1.position.z - movement1
                );
        }
        else
        {
            closing = false;
        }


       float movement2 = 1.0f * Time.deltaTime;
        currentValue2 -= movement2;

        if (currentValue2 >= 0)
        {
            Door2.position = new Vector3(
                Door2.position.x,
                Door2.position.y,
                Door2.position.z - movement2
                );
        }
        else
        {
            closing = false;
        }
       
    }

}
