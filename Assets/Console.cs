using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    private bool isActive = false;
    GameObject console;
    private new Camera camera;
    // Use this for initialization
    void Start()
    {
        console = GameObject.Find("Canvas");
        console.SetActive(isActive);
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            isActive = !isActive;
            console.SetActive(isActive);
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            GameObject text = GameObject.Find("Text");
            string input = text.GetComponent<Text>().text;
            if (input.Equals("red"))
            {
                camera.backgroundColor = Color.red;
            }
            else if (input.Equals("green"))
            {
                camera.backgroundColor = Color.green;
            }
            else if (input.Equals("blue"))
            {
                camera.backgroundColor = Color.blue;
            }
            if (input.Equals("Give me points"))
            {
                Score.player1Score++;
            }
            else if (input.Equals("Give ME! points"))
            {
                Score.player2Score++;
            }
        }
    }
}