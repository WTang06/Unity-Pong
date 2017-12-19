using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour 
{
    // Which layers should the sprite collide with?  This is used to determine whether
    // or not the sprite is jumping.  The access modifier is set to "public" so that this
    // variable can be changed in the Unity Editor.
    public string[] CollisionLayers;

    // Stores a reference to the Rigidbody2D of the sprite.  This is marked "private",
    // because we don't want it to show up (and clutter) the Inspector.  Instead, we will
    // get the reference by using the GetComponent method.
    private Rigidbody2D thisRigidBody;

    // Stores a reference to the CapsuleCollider2D of the sprite.
    private CapsuleCollider2D thisCollider;

    // Holds a reference to the Animation of the sprite.
    private Animator thisAnimator;

    // Unity method called when this GameObject is first created (instantiated).
    void Awake()
    {
        // Get a reference to the attached RigidBody2D component.
        thisRigidBody = GetComponent<Rigidbody2D>();

        // Get a reference to the attached CapsuleCollider2D component.
        thisCollider = GetComponent<CapsuleCollider2D>();

        // Get a reference to the attached Animator component.
        thisAnimator = GetComponent<Animator>();
    }

    // Unity method called once per frame.  This is part of the game loop.
    void Update()
    {
        // Get the velocity of the sprite in the horizontal (x) dimension.
        float xVel = thisRigidBody.velocity.x;

        // Determine whether the sprite is jumping by seeing if it is touching any of the
        // specified collision layers.
        bool isJumping = !thisCollider.IsTouchingLayers(LayerMask.GetMask(CollisionLayers));

        // If the horizontal velocity of the sprite is greater than zero, that means it is
        // moving to the right and we should...
        if (xVel > 0f)
        {
            // check to see if it is jumping...
            if (isJumping)
            {
                // and if it is set the animation to "JumpRight"...
                thisAnimator.SetTrigger("JumpRight");
            }
            else
            {
                // or else set the animation to "WalkRight".
                thisAnimator.SetTrigger("WalkRight");
            }

        }
        // Else if the horizontal velocity is less than zero, that means it is
        // moving to the left and we should...
        else if (xVel < 0f)
        {
            // check to see if it is jumping...
            if (isJumping)
            {
                // and if it is set the animation to "JumpLeft"...
                thisAnimator.SetTrigger("JumpLeft");
            }
            else
            {
                // or else set the animation to "WalkLeft".
                thisAnimator.SetTrigger("WalkLeft");
            }
        }
        // If the sprite is neither moving left nor right, then it is standing
        // still and...
        else
        {
            // we play the idle animation.
            thisAnimator.SetTrigger("Idle");
        }
    }
}
