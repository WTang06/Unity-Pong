using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour 
{
	public KeyCode QuitKey;

	void Update()
	{
		if (Input.GetKeyDown(QuitKey)) 
		{
			Application.Quit ();
		}
	}
		
}
