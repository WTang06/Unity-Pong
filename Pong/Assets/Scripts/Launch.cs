using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour 
{
    public float PreLaunchDelay;
    public float Force;
    public Rigidbody2D RigidBody;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(PreLaunchDelay);

        Vector2 direction = Vector2.zero;

        int rndInt = Random.Range(0, 4);

        switch (rndInt)
        {
            case 0:
                direction = new Vector2(1f, 0.5f);
                break;
            case 1:
                direction = new Vector2(1f, -0.5f);
                break;
            case 2:
                direction = new Vector2(-1f, -0.5f);
                break;
            case 3:
                direction = new Vector2(-1f, 0.5f);
                break;
        }

        RigidBody.AddForce(direction * Force);
    }
}
