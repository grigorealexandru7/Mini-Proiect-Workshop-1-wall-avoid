using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class EXEMPLU : MonoBehaviour
{
    public float viteza=100;
    public float vitezaStDr = 200;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 10;
    }

    // Update is called once per frame

    void Update()
    {
        // viteza constanta de inainte
        rb.AddForce(transform.forward * viteza);
        if (Keyboard.current.aKey.isPressed)
        {
            rb.AddForce(-transform.right * vitezaStDr);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddForce(transform.right * vitezaStDr);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "OBSTACOL")
        {
            Debug.Log("GAME OVER");
        }
    }
}
