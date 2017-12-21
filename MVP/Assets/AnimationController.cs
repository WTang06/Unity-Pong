using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour 
{
    public string[] CollisionLayers;

    private Rigidbody2D thisRigidBody;
    private CapsuleCollider2D thisCollider;
     private Animator thisAnimator;

    void Awake()
    {
        thisRigidBody = GetComponent<Rigidbody2D>();
        thisCollider = GetComponent<CapsuleCollider2D>();
        thisAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        //Cuts off here. Anything below isn't responding
        float xVel = thisRigidBody.velocity.x;

        bool isJumping = !thisCollider.IsTouchingLayers(LayerMask.GetMask(CollisionLayers));

        if (xVel > 0f)
        {
            Debug.Log("Is Updated!");
            if (isJumping)
            {
                thisAnimator.SetTrigger("JumpRight");
            }
            else
            {
                thisAnimator.SetTrigger("RunRight");
            }

        }
        else if (xVel < 0f)
        {
            if (isJumping)
            {
                thisAnimator.SetTrigger("JumpLeft");
            }
            else
            {
                thisAnimator.SetTrigger("RunLeft");
            }
        }
        else
        {
            thisAnimator.SetTrigger("Idle");
        }
    }
}
