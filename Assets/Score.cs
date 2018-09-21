using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int player1Score = 0;
    public static int player2Score = 0;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), player1Score.ToString());
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), player2Score.ToString());

        if (player1Score== 11)
        {
            player1Score = 0;
            player2Score = 0;

        }
        else if (player2Score == 11)
        {
            player1Score = 0;
            player2Score = 0;
        }
    }
}
