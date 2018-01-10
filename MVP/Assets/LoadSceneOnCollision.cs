using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOnCollision : MonoBehaviour 
{
	public string SceneToLoad;
	public float PostCollisionDelay;
	public string ColliderTag;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == ColliderTag) 
		{
			
		}
	}

	IEnumerator waitThenLoadScene
}
