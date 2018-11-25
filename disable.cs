using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class disable : MonoBehaviour {

	public Button mybutton;
	public Sprite blockA;
	public Sprite blockA_disable;

	private int counter = 0;

	// Use this for initialization
	void Start () {
		mybutton = GetComponent<Button> ();
		
	}

	public void changeButton(){
	
		counter++;
		if (counter % 2 == 0) {
			mybutton.image.overrideSprite = blockA;
		} else {
			mybutton.image.overrideSprite = blockA_disable;
		}
	}

}
