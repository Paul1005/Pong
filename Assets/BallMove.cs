using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class BallMove : MonoBehaviour
{
    public static Vector3 velocity;
    GameObject restartButton;
    GameObject player1Wins;
    GameObject player2Wins;

    // Use this for initialization
    void Start()
    {
        restartButton = GameObject.Find("RestartButton");
        player1Wins = GameObject.Find("Player1Wins");
        player2Wins = GameObject.Find("Player2Wins");
        restartButton.SetActive(false);
        player1Wins.SetActive(false);
        player2Wins.SetActive(false);
        velocity = GetComponent<Rigidbody>().velocity;
        velocity.x = -10;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = velocity;
    }

    public void OnClick()
    {
        velocity.x = -10;
        restartButton.SetActive(false);
        player1Wins.SetActive(false);
        player2Wins.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 position = gameObject.transform.position;

        if (collision.collider.CompareTag("Player"))
        {
            velocity.x = -velocity.x;
            velocity.y = velocity.y / 2 + collision.collider.attachedRigidbody.velocity.y / 3;
        }
        else if (collision.gameObject.name == "LeftWall")
        {
            Score.player2Score++;
            gameObject.transform.position = Vector3.zero;
            if (Score.player2Score == 11)
            {
                velocity.x = 0;
                velocity.y = 0;
                player2Wins.SetActive(true);
                restartButton.SetActive(true);
            }
            else
            {
                velocity.x = 10;
            }
        }
        else if (collision.gameObject.name == "RightWall")
        {
            Score.player1Score++;
            gameObject.transform.position = Vector3.zero;
            if (Score.player1Score == 11)
            {
                velocity.x = 0;
                velocity.y = 0;
                player1Wins.SetActive(true);
                restartButton.SetActive(true);
            }
            else
            {
                velocity.x = 10;
            }
        }
        else if (collision.gameObject.name == "TopWall" || collision.gameObject.name == "BottomWall")
        {
            velocity.y = -velocity.y;
        }
    }
}
