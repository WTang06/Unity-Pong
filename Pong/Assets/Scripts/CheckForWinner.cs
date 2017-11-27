using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForWinner : MonoBehaviour
{
    public DataManager DataManager;
    public float DelayBeforeGameOver = 0.5f;

    void Awake()
    {
        DataManager = GameObject.FindWithTag("DataManager").GetComponent<DataManager>();
    }

    void Update()
    {
        if (DataManager.P1Score == DataManager.WinningScore)
        {
            DataManager.WinnerMessage = "Player 1 wins!";
            StartCoroutine(waitThenLoadScene());
        }
        else if (DataManager.P2Score == DataManager.WinningScore)
        {
            DataManager.WinnerMessage = "Player 2 wins!";
            StartCoroutine(waitThenLoadScene());
        }
   }

    IEnumerator waitThenLoadScene()
    {
        yield return new WaitForSeconds(DelayBeforeGameOver);
        SceneManager.LoadScene("GameOver");
    }

}