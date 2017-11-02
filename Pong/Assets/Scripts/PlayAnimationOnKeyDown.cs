using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyDown : MonoBehaviour 
{
    public KeyCode Key;
    public string TriggerName;
    public Animator TargetAnimator;

    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            TargetAnimator.SetTrigger(TriggerName);
        }
    }
}
