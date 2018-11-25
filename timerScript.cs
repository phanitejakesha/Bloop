using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour {

	public static int timeLeft;
	public Text countDowntext;
	scoreUpdate sc= new scoreUpdate();

	// Use this for initialization
	void Start () {
		StartCoroutine ("LoseTime");
		Time.timeScale = 1;
		timeLeft = 30;
	}
	
	// Update is called once per frame
	void Update () {

		countDowntext.text = ("" + timeLeft);
		//Debug.Log ("timelft"+timeLeft);

		if (timeLeft <= 0) { // timer expired
			PlayerPrefs.SetInt ("yourscore", scoreUpdate.score);

			Debug.Log("Timescript Score:" + scoreUpdate.score);
			if (PlayerPrefs.HasKey ("highestScore")) {
                    int high = PlayerPrefs.GetInt ("highestScore");
				if (scoreUpdate.score > high) {
					PlayerPrefs.SetInt ("highestScore", scoreUpdate.score);
                        if (PlayerPrefs.HasKey("Username"))
                        {
                            PlayerPrefs.SetString("HighestUser", PlayerPrefs.GetString("Username"));
                        }
                    }		
			} else {
				PlayerPrefs.SetInt ("highestScore", scoreUpdate.score);
                PlayerPrefs.SetString("HighestUser", PlayerPrefs.GetString("Username"));
                }

			sc.reset ();
			SceneManager.LoadScene ("Gameover", LoadSceneMode.Single);
		}
	}

	IEnumerator LoseTime(){

		while (true) {

			yield return new WaitForSeconds (1);
			timeLeft--;
		}
	}

}
