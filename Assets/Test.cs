using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private bool moveRight;

    Rigidbody2D rb;
    Vector2 position;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveRight = true;
        position = new Vector2(0, 0);
     
    }

    private void FixedUpdate()
    {
        if(moveRight == true)
        MoveRight();
        if(moveRight == false)
        MoveLeft();
       
    }

    void MoveRight()
    {
        rb.MovePosition(position);
        rb.MoveRotation(position.x * 72);
        position.x += 0.1f;
        //position.y += 0.5f*Mathf.Sin(2*Mathf.PI*position.x);
        if(position.x >= 5)
        {
            moveRight = false;
        }
    }
    void MoveLeft()
    {
        rb.MovePosition(position);
        rb.MoveRotation(position.x * 72);
        position.x -= 0.1f;
        //position.y -= 0.5f*Mathf.Sin(2*Mathf.PI*position.x);
        if (position.x <= -5)
        {
            moveRight = true;
        }

    }
} 
