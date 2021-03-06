using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementScoreOnCollision : MonoBehaviour
{
    public string ColliderTag;
    public DataManager DataManager;

    public enum Player { P1, P2 }
    public Player PlayerWhoScored;

    void Awake()
    {
        DataManager = GameObject.FindWithTag("DataManager").GetComponent<DataManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ColliderTag)
        {
            if (PlayerWhoScored == Player.P1)
            {
                DataManager.P1Score++;
                // Increment player one's score.
            }
            else if (PlayerWhoScored == Player.P2)
            {
                DataManager.P2Score++;
                // Increment player two's score.
            }
            else
            {
                throw new UnityException("Invalid Player!");
            }
        }
    }
}
