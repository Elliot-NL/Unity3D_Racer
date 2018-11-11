using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // reports on where the player is: Debug.Log(player.position.z);
        scoreText.text = "Score: " + player.position.z.ToString("0");
    }
}
