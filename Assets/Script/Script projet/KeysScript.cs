using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysScript : MonoBehaviour {

    public Text RemainKeysText;
    public int keys = 0;
    public int RemainKeys;

    void Start()
    {
        RemainKeys = GameObject.FindGameObjectsWithTag("Key").Length;
        RemainKeysText.text = "Clés restantes : " + RemainKeys;

    }
    public void AddKey()
    {
        keys++;
        RemainKeys--;
        RemainKeysText.text = "Clés restantes : " + RemainKeys;
    
    }

    public bool CanOpenDoor()
    {
        if (RemainKeys <= 0)
        {
            return true;
        }
        return false;
    }
}
