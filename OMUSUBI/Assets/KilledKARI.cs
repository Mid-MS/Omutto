using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilledKARI : MonoBehaviour
{

    void Start()
    {
        
    }
    
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //*
        if (collision.gameObject.tag == "Rock")
        {
            Debug.Log("a");

            //transform.position = new Vector3(58.0f, 23.0f, 0.0f);
            Destroy(gameObject);
        }
        //*/
    }
}
