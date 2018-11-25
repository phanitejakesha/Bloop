using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject spawnees;
	public Transform spawnPos;
	public Vector2 center = new Vector2(0.0f, -6.0f);


	int randomInt;
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0)){
			//f
			//SpawnRandom();
	//}
		if (Random.Range(1, 400) < 45){
			//InvokeRepeating ("SpawnRandom", 1, 100);
			SpawnRandom();
		}
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				SceneManager.LoadScene ("StartPage");
			}
		}
}
	void SpawnRandom(){
		//randomInt = Random.Range(0, spawnees.Length);
		Instantiate(spawnees, PositionGenerator(), Quaternion.identity);
	
	}

	Vector2 PositionGenerator(){
		Vector2 pos = center + new Vector2 (Random.Range (0.75f, 6.23f), 0.0f);
		return pos;
	}



}
