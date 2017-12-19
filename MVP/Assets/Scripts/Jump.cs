using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
    public KeyCode JumpKey;
    public float Force;
    public string[] CollisionLayers;
    public Run RunScript;

    private Rigidbody2D thisRigidBody;

    private CapsuleCollider2D thisCollider;

    void Awake()
    {
        thisRigidBody = GetComponent<Rigidbody2D>();

        thisCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        bool isJumping = !thisCollider.IsTouchingLayers(LayerMask.GetMask(CollisionLayers));

        if (Input.GetKeyDown(JumpKey) && !isJumping)
        {
            thisRigidBody.AddForce(transform.up * Force);
        }
        if (isJumping)
        {
            RunScript.enabled = false;
        }
        else
        {
            RunScript.enabled = true;
        }
    }
}