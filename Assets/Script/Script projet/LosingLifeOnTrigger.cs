using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LosingLifeOnTrigger : MonoBehaviour
{

    int playerHealth; //This will be set in Inspector, to a number such as 10
    public Text PlayerHealthText;
    public Canvas GameOver;

    void Start()
    {
        playerHealth = 3;
        PlayerHealthText.text = "Vie Restante : " + playerHealth;
        GameOver.enabled = false;
        PlayerHealthText.enabled = true;
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerHealth = playerHealth - 1;
            if (playerHealth <= 0)
            {

                Death();
            }
            PlayerHealthText.text = "Vie Restante : " + playerHealth;
        }
    }

    void Death()
    {
        if (playerHealth <= 0)
        {
            GameOver.enabled = true;
            PlayerHealthText.enabled = false;

        }

    }

}