using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour {
	
	void Update(){
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit ();

			}
		}
	}

	public void SceneLoader(int SceneIndex){

		SceneManager.LoadScene (SceneIndex);
	}

}
