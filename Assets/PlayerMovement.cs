using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    private Rigidbody2D rb;
    private BoxCollider2D collid;
    private int counter = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        collid = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xAxis * 7f, rb.velocity.y);
        
        if (Input.GetKeyDown("space") && counter == 0)
        {
            rb.velocity = new Vector3(0, 7, 0);
            counter = 1;
        }
    }

    // OnCollisionEnter2D is called when a collision occurs.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset the counter when any collision occurs.
        counter = 0;
    }
}
