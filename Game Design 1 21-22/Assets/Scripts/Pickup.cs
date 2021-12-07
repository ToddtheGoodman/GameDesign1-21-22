using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public Animator myAnim;


    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // add +1 to scoreValue from PickupScore script
        PickupScore.scoreValue += 1;
        myAnim.Play("CoinDestroy");
        StartCoroutine("CoinDestroy");
        
    }

    IEnumerator CoinDestroy()
    {
        yield return new WaitForSeconds(.4f);
        Destroy(gameObject);
    }


}
