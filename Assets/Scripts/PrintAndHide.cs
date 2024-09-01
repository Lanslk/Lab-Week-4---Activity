using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    private int i = 3;

    public Renderer rend;
    private int randomNumber;


    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(150, 251);

    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        
        // Check if the game object's tag is "Red" and if i = 100
        if (gameObject.tag == "Red" && i == 100)
        {
            // Deactivate the game object
            gameObject.SetActive(false);
        }
        // Check if the game object's tag is "Blue" and if i equals the random number
        else if (gameObject.tag == "Blue" && i == randomNumber)
        {
            // Disable the Renderer component
            rend.enabled = false;
        }   
    }
}
