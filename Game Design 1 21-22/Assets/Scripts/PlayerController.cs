using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float sprintSpeed;

    public Rigidbody2D myRB;

    public Vector2 moveInput;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();
        
        myRB.velocity = moveInput * moveSpeed;


        // move the player's Transform component        
        //transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * Input.GetAxisRaw("Horizontal"));
        //transform.Translate(Vector2.up * Time.deltaTime * moveSpeed * Input.GetAxisRaw("Vertical"));
        
        //if I press left shift move at sprintSpeed otherwise move at moveSpeed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //transform.Translate(Vector2.right * Time.deltaTime * sprintSpeed * Input.GetAxisRaw("Horizontal"));
            //transform.Translate(Vector2.up * Time.deltaTime * sprintSpeed * Input.GetAxisRaw("Vertical"));
        }

    }
}
