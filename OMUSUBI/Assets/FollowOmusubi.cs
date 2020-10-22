using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOmusubi : MonoBehaviour
{
    public GameObject Omusubi;
    public Transform OmuTf;

    void Start()
    {
        OmuTf = Omusubi.GetComponent<Transform>();
    }
    
    void Update()
    {
        transform.position = new Vector3(OmuTf.position.x - 8.0f, Mathf.Tan(Mathf.PI / 12) * OmuTf.position.x + 2.0f, -10.0f);
    }
}
