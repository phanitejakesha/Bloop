using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {

	public Text scoreText;
	//public Text text;
	public static int score = 0,score2=0;
	static string quote1 = "";
	public string[] quotes = new string[30];

	//string quotelist = "test quote";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ""+ quote1; 

	}

	public void ScoreUpdate(){
		//score += 1;
		quotes[0] = "If you can dream it, you can do it";
		quotes[1] = "If you love a flower, don’t pick it up.Because if you pick it up it dies and it ceases to be what you love.So if you love a flower, let it be.Love is not about possession.Love is about appreciation ";
		quotes[2] = "Be — don't try to become";
		quotes[3] = "Be gentle with yourself.You are a child of the universe no less than the trees and the stars; you have a right to be here.";
		quotes[4] = "We may encounter many defeats but we must not be defeated. ";
		quotes[5] = "Do not take life too seriously. You will never get out of it alive. Elbert Hubbard";
		quotes[6] = "To succeed in life, you need three things: a wishbone, a backbone and a funny bone";
		quotes[7] = "Age is something that doesn't matter, unless you are a cheese";
		quotes[8] = "Women listen to music because they are in love. Men listen to music because they want to fall in love.";
		quotes[9] = "There is no such a thing as ignorance, but only degrees of wisdom";
		quotes[10] = "The greatest test of courage on earth is to bear defeat without losing heart";
		quotes[11] = "Home is the only place where one does not get homesick.";
		quotes[12] = "The best thing about an enemy is that he tells the truth about you.";
		quotes[13] = "Don’t Let Yesterday Take Up Too Much Of Today";
		quotes[14] = "You Learn More From Failure Than From Success. Don’t Let It Stop You. Failure Builds Character ";
		quotes[15] = "It’s Not Whether You Get Knocked Down, It’s Whether You Get Up";
		quotes[16] = "If a book about failures doesnt sell, is it a Success? ";
		quotes[17] = "Failure Will Never Overtake Me If My Determination To Succeed Is Strong Enough.";
		quotes[18] = "We May Encounter Many Defeats But We Must Not Be Defeated";
		quotes[19] = "Whether You Think You Can Or Think You Can’t, You’re Right. ";
		quotes [20] = "i always wanted to be somebody, but now i realize i should have been more specific!";
		
		int index = Random.Range (0, 20);
		quote1 = quotes[index];
		scoreText.text = "" + quote1;
	}
	public void missedBubble(){
		score2 += 1;
	}

}


