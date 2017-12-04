using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOrQuit : MonoBehaviour 
{
    public KeyCode RestartKey;
    public KeyCode QuitKey;
    public DataManager DataManager;

    void Awake()
    {
        DataManager = GameObject.FindWithTag("DataManager").GetComponent<DataManager>();
    }
    //This gets the DataManager for the code.

    void Update()
    {
        if (Input.GetKeyDown(RestartKey))
        {
            DataManager.P1Score = 0;
            DataManager.P2Score = 0;
            DataManager.WinnerMessage = "";
            SceneManager.LoadScene("Title");
        }
        else if (Input.GetKeyDown(QuitKey))
        {
            Application.Quit();
        }
    }
}
