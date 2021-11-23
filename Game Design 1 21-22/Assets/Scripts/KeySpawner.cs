using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{

    public GameObject key;

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
        //Spawn - What, Where (Position), Rotation
        Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(gameObject);
    }

}
