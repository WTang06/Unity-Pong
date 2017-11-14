using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
    public KeyCode UpKey;
    public KeyCode DownKey;
    public Rigidbody2D RigidBody;
    public float Force;

    void Update()
    {
        if (Input.GetKey(UpKey))
        {
            RigidBody.AddForce(Vector2.up * Force);
        }
        else if (Input.GetKey(DownKey))
        {
            RigidBody.AddForce(Vector2.down * Force);
        }
    }
}
 