using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyDown : MonoBehaviour 
{
    public KeyCode Key;
    public string TriggerName;
    public Animator TargetAnimator;
    public float InDelay = 1f;

//    private bool acceptingInput = false;
//
    IEnumerator Start()
    {
        yield return new WaitForSeconds(InDelay);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }

        TargetAnimator.SetTrigger(TriggerName);
    }

//    void Start()
//    {
//        StartCoroutine(waitThenAcceptInput());
//    }
//
//    IEnumerator waitThenAcceptInput()
//    {
//        yield return new WaitForSeconds(InDelay);
//        acceptingInput = true;
//    }
//
//    void Update()
//    {
//        if (acceptingInput && Input.GetKeyDown(Key))
//        {
//            TargetAnimator.SetTrigger(TriggerName);
//        }
//    }
}
