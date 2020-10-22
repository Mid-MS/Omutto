using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Rigidbody2D rb;
    private float spdCheck;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (Mathf.Abs(transform.position.x - spdCheck) != 0)
            {
                if (Mathf.Abs(transform.position.x - spdCheck) < -0.10)
                {
                    rb.AddForce(new Vector2(1.0f, 0.0f));
                }
            }
        }
        else
        {
            if (Mathf.Abs(transform.position.x - spdCheck) != 0)
            {
                if (Mathf.Abs(transform.position.x - spdCheck) > -0.20)
                {
                    rb.AddForce(new Vector2(-1.2f, 0.0f));
                    rb.constraints = RigidbodyConstraints2D.None;
                }
            }
        }
        /*
        Debug.Log(transform.position.x);
        Debug.Log(spdCheck);
        Debug.Log(transform.position.x - spdCheck);
        //*/
        spdCheck = transform.position.x;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //rb.AddForce(new Vector3(-1.3f, 0.0f, 0.0f));
            //Debug.Log("a");
        }
    }
}
