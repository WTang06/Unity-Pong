using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnCollision : MonoBehaviour 
{
    public string SceneToLoad;
    public float PostCollisionDelay;
    public string ColliderTag;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ColliderTag)
        {
            StartCoroutine(waitThenLoadScene());
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ColliderTag)
        {
            StartCoroutine(waitThenLoadScene());
        }
    }


    IEnumerator waitThenLoadScene()
    {
        yield return new WaitForSeconds(PostCollisionDelay);
        SceneManager.LoadScene(SceneToLoad);
    }

   
}


