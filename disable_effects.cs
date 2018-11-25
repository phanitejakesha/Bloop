using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class disable_effects : MonoBehaviour {

	public Button mybuttone;
	public Sprite blockA;
	public Sprite blockA_disable;

	private int counter = 0;

	// Use this for initialization
	void Start () {
		mybuttone = GetComponent<Button> ();

	}

	public void changeButton(){

		counter++;
		if (counter % 2 == 0) {
			mybuttone.image.overrideSprite = blockA;
		} else {
			mybuttone.image.overrideSprite = blockA_disable;
		}
	}

}
