using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour 
{
    public string SceneToLoad = "";
    public float Delay = 0;

    void Start()
    {
        StartCoroutine(delayThenLoadScene());
    }

    IEnumerator delayThenLoadScene()
    {
        yield return new WaitForSeconds(Delay);
        //will pause execution of the coroutine

        SceneManager.LoadScene(SceneToLoad);
    }

}


// The original LoadScene component
//    private double elapsedTime = 0;
//
//    void Update()
//    {
//        elapsedTime += Time.deltaTime;
//
//        if (elapsedTime > Delay)
//        {
//             SceneManager.LoadScene(SceneToLoad);
//        }
//    }

