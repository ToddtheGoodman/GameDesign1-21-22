using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float sprintSpeed;    

    public Rigidbody2D myRB;

    private Vector2 moveInput;
    
    public Animator myAnim;


    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Attack();
        if (GameObject.Find("Canvas").GetComponent<HealthScore>().healthValue < 1)
        {
            Destroy(gameObject);
        }

    }   
    
    void Movement()
    {
        // Sets the moveInput (a Vector2) to the Horizontal and Vertical controls from the player input
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        // Normalizes the speed when moving diagonal (see Subnautica)
        moveInput.Normalize();

        // Adds velocity to the RigidBody * moveSpeed variable (float)
        myRB.velocity = moveInput * moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Adds velocity to the RigidBody * sprintSpeed variable (float)
            myRB.velocity = moveInput * sprintSpeed;
        }

    }

    void Attack()
    {
        //This will trigger the "Attack" condition to switch animations
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetTrigger("Attack");
        }
    }
      
}
