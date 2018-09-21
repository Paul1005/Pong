using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : MonoBehaviour {
    GameObject ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Sphere");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 position = gameObject.transform.position;
        Vector3 velocity = GetComponent<Rigidbody>().velocity;

        if (ball.transform.position.y> gameObject.transform.position.y)
        {
            if (position.y < 5 && velocity.y < 2.5)
            {
                velocity.y += 2.5f;
            }
        }
        else if (ball.transform.position.y < gameObject.transform.position.y)
        {
            if (position.y > -5 && velocity.y > -2.5)
            {
                velocity.y -= 2.5f;
            }
        }
        else
        {
            velocity.y = 0;
        }
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
