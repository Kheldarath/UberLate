using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;
    float XMove = 0.0f;
    [SerializeField] float turnSpeed = 0.5f;


    void Start()
    {

    }

    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float acceleration = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        MoveCar(turnAmount, acceleration);        
    }
    void MoveCar(float turnAmount, float acceleration)
    {
        transform.Rotate(XMove, acceleration, -turnAmount);
        transform.Translate(XMove, acceleration, 0);
    }

    /*void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("FUCK YOU TOO BUDDY!");

    }*/
} 