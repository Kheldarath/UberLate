using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
       
        Debug.Log("FUCK YOU TOO BUDDY!");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OW SHIT MY FOOT!");
    }
}
