using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.gameObject.name);
        gameObject.GetComponent<Transform>().localScale =
            new Vector3(3, 3, 3);
	}



}
