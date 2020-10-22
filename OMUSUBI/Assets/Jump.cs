using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool JumpKey = false;
    Rigidbody2D rb;
    public float JumpNum = 100.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (JumpKey == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //*
                rb.AddForce(new Vector2(0.0f, JumpNum));
                //*/
                JumpKey = true;
            }
        }
        if (JumpKey == true)
        {
            if (Input.GetKey(KeyCode.Space)) { }
            else { JumpKey = false; }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        /*
        if (collision.gameObject.tag == "Ground")
        {
            if (JumpKey == true)
            {
                rb.AddForce(new Vector2(0.0f, JumpNum));
                JumpKey = false;
            }
        }
        //*/
    }
}
