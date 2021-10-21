using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    public string wordz;
    // Start is called before the first frame update
    void Start()
    {
        print("You are stranded on a beach");
        print("Press Q to walk the shoreline");
        print("Press W to go into the jungle");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("You found a box");
            print("Press E to open the box");
            print("Press R to toss the box in the water");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("You run into a venomous snake, you die");
        }

    }
}
