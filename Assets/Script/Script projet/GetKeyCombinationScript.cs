using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetKeyCombinationScript : MonoBehaviour
{

    public string AimedResult = "5026";
    public string CurrentResult = "";

    public bool success = false;

    public Text indicationText;
    public bool typing = false;

    public bool isInTrigger = false;


    public float maxOpenValue;
    public Transform Door;
    public bool open = false;
    public bool closing = true;
    private float currentValue1 = 0;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!isInTrigger)
        {
            typing = false;
            indicationText.text = "";
        }
        if (typing)
        {
            if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0))
            {
                AddNumber(0);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {

                AddNumber(1);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
            {

                AddNumber(2);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
            {

                AddNumber(3);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
            {

                AddNumber(4);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
            {

                AddNumber(5);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
            {

                AddNumber(6);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
            {

                AddNumber(7);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
            {

                AddNumber(8);
                GetNextNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
            {
                AddNumber(9);
                GetNextNumber();

            }
        }

        if (open) OpenDoor();
        if (closing) CloseDoor();

    }

    void GetNextNumber()
    {
        if (CurrentResult.Length < AimedResult.Length)
        {
            indicationText.text = "Enter number " + (CurrentResult.Length + 1);
            typing = true;
        }
        else if (CurrentResult.Length == AimedResult.Length)
        {
            if (CurrentResult == AimedResult)
            {
                typing = false;
                success = true;
                indicationText.text = "You found it";

                open = true;
                closing = false;
            }
            else
            {
                CurrentResult = "";
                GetNextNumber();
            }

        }
        else if (CurrentResult.Length > AimedResult.Length)
        {
            indicationText.text = "Error too long";
        }
    }

    void AddNumber(int number)
    {
        CurrentResult += number.ToString();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            isInTrigger = true;
            GetNextNumber();
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            isInTrigger = false;
        }
    }

    void OpenDoor()
    {
        float movement = -1.0f * Time.deltaTime;
        currentValue1 += movement;

        if (currentValue1 >= maxOpenValue)
        {
            Door.position = new Vector3(
                Door.position.x,
                Door.position.y,
                Door.position.z + movement
                );
        }
        else
        {
            open = false;
        }

    }

    void CloseDoor()
    {
        float movement = -1.0f * Time.deltaTime;
        currentValue1 -= movement;

        if (currentValue1 <= 0)
        {
            Door.position = new Vector3(
                Door.position.x,
                Door.position.y,
                Door.position.z - movement
                );
        }
        else
        {
            closing = false;
        }
    }
}