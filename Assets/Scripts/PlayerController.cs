using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody ball; //ball = player
    public float speed = 700; //speed of the ball
    private int score = 0; //score = coins

    //excecution of the movement of the ball once per frame
    //Input.GetKey = receives the Key od the movement(WASD)
    //ball.AddForce(x, y, z) = move the ball accordint to Input.GetKey
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            ball.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("s"))
            ball.AddForce(0, 0, -speed * Time.deltaTime);
        if (Input.GetKey("d"))
            ball.AddForce(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("a"))
            ball.AddForce(-speed * Time.deltaTime, 0, 0);
    }

    //possible interaccions with other objs
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            Debug.Log ("Score: " + score);
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}