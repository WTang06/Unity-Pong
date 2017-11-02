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
        SceneManager.LoadScene(SceneToLoad);
    }
}
