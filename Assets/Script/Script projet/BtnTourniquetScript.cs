using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnTourniquetScript : MonoBehaviour
{

    public Text text;
    bool cliquable = false;
    GameObject Tourniquet;

    void Start()
    {
        text.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && cliquable)
        {
            Tourniquet.GetComponent<TourniquetScript>().Tourne();
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "BoutonTourniquey")
        {
            cliquable = true;
            text.enabled = true;
            Tourniquet = c.gameObject.transform.parent.transform.parent.gameObject;
        }
    }
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "BoutonTourniquey")
        {
            cliquable = false;
            text.enabled = false;
            Tourniquet = null;
        }
    }
}
