using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jumpForce;
    private float moveInput;
    //private bool isGrounded = true;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    /*void Update()
    {
        //движение вправво и влево
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }
        //прыжок
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb.AddForce (Vector2.up * 3500);
        }
    }*/
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    private void Update()
    {        
        //прыжок
        if (Input.GetKeyDown (KeyCode.Space))
        {
            //rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
