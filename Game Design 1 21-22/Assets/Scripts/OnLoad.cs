using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLoad : MonoBehaviour
{

    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").transform.position = spawnPoint.transform.position;
    }

   
}
