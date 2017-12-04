using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscenseurScript : MonoBehaviour
{


    public float maxElevateValue;
    public Transform Ascenseur;

    public bool monte = false;
    private float currentValue = 0;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (monte) ElevateAscenseur();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "Perso")
        {
            monte = true;

        }
    }


    void ElevateAscenseur()
    {
        float movement = 1.0f * Time.deltaTime;
        currentValue += movement;

        if (currentValue <= maxElevateValue)
        {
            Ascenseur.position = new Vector3(
                Ascenseur.position.x ,
                Ascenseur.position.y + movement,
                Ascenseur.position.z
                );
        }
        else
        {
            monte = false;
        }


    }
}
