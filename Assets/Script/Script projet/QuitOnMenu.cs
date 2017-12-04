using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Quit();
	}

    public void Quit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Application.Quit();
        }
    }
}
