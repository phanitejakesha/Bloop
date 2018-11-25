using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour {

	public Transform canvas;
	//public Transform Player;
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Pause ();
		}
	}

	public void Pause(){
		
		if (canvas.gameObject.activeInHierarchy == false) {
			canvas.gameObject.SetActive (true);


			Time.timeScale = 0;
		} else {
			canvas.gameObject.SetActive (false);
			//CancelInvoke ("SpawnRandom");
		
			Time.timeScale = 1;

		}


	/*if (Time.timeScale == 0) {
			if (canvas.gameObject.activeInHierarchy == false) {
				canvas.gameObject.SetActive (true);
				Time.timeScale = 1;
			}
		} else if (Time.timeScale == 1) {
			if (canvas.gameObject.activeInHierarchy == false) {
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
			}	
		}
*/	}
}
