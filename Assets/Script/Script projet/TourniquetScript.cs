using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourniquetScript : MonoBehaviour
{

    float[] positions;
    int positionVisee;
    public float speed;
    // Use this for initialization
    void Start()
    {
        positions = new float[]{0.0f, 90.0f, 180.0f, 270.0f};
        positionVisee = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, positions[positionVisee], 0), speed);

    }

    public void Tourne()
    {
        positionVisee++;
        if (positionVisee == 4)
        {
            positionVisee = 0;
        }
    }
}
