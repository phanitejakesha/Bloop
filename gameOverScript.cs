using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour {

	public int timeLeft = 5;
	public Text countDowntext,highscore, HighestUser;
	scoreUpdate sc= new scoreUpdate();

	// Use this for initialization
	void Start () {
		StartCoroutine ("LoseTime");
		Time.timeScale = 1;

	}

	// Update is called once per frame
	void Update () {

		countDowntext.text = "" + PlayerPrefs.GetInt("highestScore");
        Debug.Log("Username" + PlayerPrefs.GetString("Username"));
        HighestUser.text = "By " + PlayerPrefs.GetString("HighestUser");

        highscore.text = "" + PlayerPrefs.GetInt ("yourscore");
		if (timeLeft == 0) {
			SceneManager.LoadScene ("StartPage", LoadSceneMode.Single);
			sc.reset ();
		}
	}

	IEnumerator LoseTime(){

		while (true) {

			yield return new WaitForSeconds (1);
			timeLeft--;
		}
	}

}
