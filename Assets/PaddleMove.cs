using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {
    public KeyCode paddleUp = KeyCode.W;
    public KeyCode paddleDown = KeyCode.S;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = gameObject.transform.position;
        Vector3 velocity = GetComponent<Rigidbody>().velocity;

        if (Input.GetKey(paddleUp) /*|| Input.GetButton("joystick button 0")*/)
        {
            if (position.y < 5 && velocity.y < 10)
            {
                velocity.y += 10;
            }
        }
        else if (Input.GetKey(paddleDown) /*|| Input.GetButton("joystick button 1")*/)
        {
            if (position.y > -5 && velocity.y > -10)
            {
                velocity.y -= 10;
            }
        }
        else
        {
            velocity.y = 0;
        }
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
