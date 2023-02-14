using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D r_body;
    float constantSpeed = 18.0f;
    
    void Start()
    {
        //get rigidbody
        r_body = gameObject.GetComponent<Rigidbody2D>();

        //set initial direction
        Vector2 taco = new Vector2(13.0f, 20.0f);

        //add initial force
        r_body.AddForce(taco, ForceMode2D.Impulse);
    }

    
    void Update()
    {
        //control speed
        r_body.velocity = constantSpeed * (r_body.velocity.normalized);
    }
}
