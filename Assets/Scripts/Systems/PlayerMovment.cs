using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{


    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;


    // Update is called once per frame
    void Update()
    {
  

        if (transform.position.y >= Screen.height)
        {
            transform.position = new Vector3(transform.position.x, 2, 0);
        }

        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);



    }

    void Move()
    {

        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
    
}
