using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyDown : MonoBehaviour 
{
    public KeyCode Key;
    public string TriggerName;
    public Animator Animator;

    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            
        }
    }
}
