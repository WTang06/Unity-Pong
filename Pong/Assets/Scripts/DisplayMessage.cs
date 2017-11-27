using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMessage : MonoBehaviour 
{
    public DataManager DataManager;
    public Text WinnerText;

    void Awake()
    {
        DataManager = GameObject.FindWithTag("DataManager").GetComponent<DataManager>();
    }

    void Start()
    {
        WinnerText.text = DataManager.WinnerMessage; 
    }
}
