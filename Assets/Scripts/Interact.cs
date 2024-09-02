using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Text Prompt;
    public float RayDist = 3;
    private bool HandsFull;
    
    void Start()
    {
        HandsFull = false;
    }


    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, RayDist))
        {
            if (hit.collider.CompareTag("Movable"))
            {
                Prompt.text = "Press E to pick up";

                if (Input.GetKeyDown("e"))
                {
                    HandsFull = true;
                    PickUp();
                }
            }

            if (hit.collider.CompareTag("InteractableHF"))
            {
                Prompt.text = "Press E to interact";
                //FINISH THIS SHIT LATER FUCKING FATASS
            }
        }
        else
        {
            Prompt.text = "";
        }
    }
}
