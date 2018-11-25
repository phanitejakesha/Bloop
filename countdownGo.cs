using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class countdownGo : MonoBehaviour {

	public GameObject one,two,three,four,five,six;
	public static float timeLeft = 4f;
	// Use this for initialization
	void Start () {
        Destroy(one, 1);
        Destroy(two, 1);
        Destroy(three, 2);
        Destroy(four, 2);
        Destroy(five, 3);
        Destroy(six, 3);
        int y = SceneManager.GetActiveScene ().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timeLeft = 4f;
			SceneManager.LoadScene ("save1");

		}
}

}