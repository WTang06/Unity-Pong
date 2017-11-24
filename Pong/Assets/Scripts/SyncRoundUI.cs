using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyncRoundUI : MonoBehaviour 
{
    public DataManager DataManager;
    public Text TextToUpdate;

    public enum Player { P1, P2 }
    public Player PlayerScore;

    void Awake()
    {
        DataManager = GameObject.FindWithTag("DataManager").GetComponent<DataManager>();
    }

    void Update()
    {
        if (PlayerScore == Player.P1)
        {
            TextToUpdate.text = DataManager.P1Score;
        }
        else if (PlayerScore == Player.P2)
        {
            TextToUpdate.text = DataManager.P2Score;
        }
        else
        {
            throw new UnityException("Invalid Player!");
        }
    }
}
