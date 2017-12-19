using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour 
{
   
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public float Force;

    public Rigidbody2D thisRigidBody;

    void Awake()
    {
        thisRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(LeftKey))
        {
            thisRigidBody.AddForce(-transform.right * Force);
        }
        else if (Input.GetKey(RightKey))
        {
            thisRigidBody.AddForce(transform.right * Force);
        }
    }
}
