using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("You are stranded on a beach");
        print("Press Q to walk into the jungle");
        print("Press W to walk along the beach");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("You hear a growl coming from a close by bush");
            print("Press E to run away");
            print("Press R to move closer to the noise");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("The beach is lovely");
        }

    }
}
