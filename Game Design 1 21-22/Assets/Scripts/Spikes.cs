using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //When entering the trigger, - 1 from healthValue in HealthScore script
        GameObject.Find("Canvas").GetComponent<HealthScore>().healthValue -= 1;
        //Destroy(other.gameObject);
    }


}
