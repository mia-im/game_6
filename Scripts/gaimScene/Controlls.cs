using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
    }

    //вправо влево
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    //прыжок
    private void Update()
    {        
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
