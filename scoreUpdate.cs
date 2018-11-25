using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreUpdate : MonoBehaviour {

	public Text scoreText;
	//public Text text;
	public static int score = 0,score2=0;
	// Use this for initialization
	void Start () {
		score = 0;
	}

	// Update is called once per frame
	void Update () {
		scoreText.text = "" + score; 

	}

	public void scUpdate(){
		score += 1;
	}
	public void missedBubble(){
		score2 += 1;
	}
	public void reset(){
		score = 0;
	}


}