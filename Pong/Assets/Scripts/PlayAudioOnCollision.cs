using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour 
{
    public AudioSource TargetAudioSource;

    void OnCollisionEnter2D(Collision2D collision)
    {
        TargetAudioSource.Play();
    }
}