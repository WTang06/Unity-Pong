using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnKeyDown : MonoBehaviour 
{
    public string SceneToLoad;
    public float PreKeyDelay = 1f;
    public float PostKeyDelay = 1f;
    public KeyCode Key = KeyCode.Return;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(PreKeyDelay);

        while (!Input.GetKeyDown(Key))
        {
            yield return null;
        }

        yield return new WaitForSeconds(PostKeyDelay);

        SceneManager.LoadScene(SceneToLoad);
    }

}
