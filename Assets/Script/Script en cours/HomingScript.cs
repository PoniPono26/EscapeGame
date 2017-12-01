using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingScript : MonoBehaviour {

    public Transform TargetTransform;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            TargetTransform.localPosition,
            0.01f);
            
	}
}
