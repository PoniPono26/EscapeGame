using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastScript : MonoBehaviour {

    private Camera cam;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward,out hit))
        {
            Debug.Log(hit.collider.gameObject.name);

            Debug.DrawRay(transform.position,
                transform.forward.normalized * hit.distance, Color.red); //on trace une ligne qui va récupérer les infos de l'objet
        }
	}
}
