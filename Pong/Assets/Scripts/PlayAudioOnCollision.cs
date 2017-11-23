using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour 
{
    public string ColliderTag;
    public AudioSource TargetAudioSource;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ColliderTag)
        {
            TargetAudioSource.Play();
        }
       
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ColliderTag)
        {
            TargetAudioSource.Play();
        }
    }
}