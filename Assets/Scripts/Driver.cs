using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;    
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;



    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float acceleration = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        MoveCar(turnAmount, acceleration);        
    }
    void MoveCar(float turnAmount, float acceleration)
    {
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, acceleration, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            moveSpeed = slowSpeed;
            Debug.Log("Watch what you're doing!");
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Powerup")
        {
            moveSpeed = boostSpeed;
            Debug.Log("We're speeding now!");
        }
    }
} 