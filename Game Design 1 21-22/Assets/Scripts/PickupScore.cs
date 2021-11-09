using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupScore : MonoBehaviour
{
    public Text scoreText;
    public static int scoreValue;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue > 5)
        {
            scoreText.text = "You Win!!!!";
        }
        else
        {
            scoreText.text = "Score: " + scoreValue;
        }        
        
    }
}
