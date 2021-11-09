using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float sprintSpeed;

    public Rigidbody2D myRB;

    public Vector2 moveInput;

    public SpriteRenderer renderColor;

    
    // Start is called before the first frame update
    void Start()
    {
        renderColor.color = Color.magenta;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
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
}
